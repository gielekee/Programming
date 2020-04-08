$timeout = New-TimeSpan -Minutes 30
$sw = [diagnostics.stopwatch]::StartNew()

Do {
#krijg variabelen
$params = @{
    'namespace' = 'root\CIMV2'
    'Filter' = "Displayname='workstation'"
    'Class' = 'Win32_Service'
} 
$workstation = Get-WmiObject @params
$CPU = Get-WmiObject -Query "SELECT LoadPercentage FROM Win32_Processor"
$RAM = Get-WmiObject -class "win32_physicalmemory"

$disk = Get-WmiObject win32_logicaldisk -Filter "Drivetype=3" | `
Select-Object @{Label = "PC-Naam: ";Expression = {$_.SystemName}}, `
@{Label = "Drive Letter: ";Expression = {$_.DeviceID}}, `
@{Label = "Totale opslag (GB): ";Expression = {"{0:N1}" -f( $_.Size / 1gb)}}, `
@{Label = "Beschikbare opslag (GB): ";Expression = {"{0:N1}" -f( $_.Freespace / 1gb)}}, `
@{Label = "Beschikbare opslag (%): ";Expression = {"{0:P0}" -f( $_.freespace/$_.size)}}

#doe iets
            Clear-Host
            Write-host -ForegroundColor Green "Guardian Mode Activated, (Checking 1 second)"
            Write-Host -ForegroundColor cyan "Workstation status is $($workstation.state)"
           
            Write-Host -ForegroundColor cyan "CPU Load is $($CPU.LoadPercentage)"
            
            Write-Host "Total Memory:" -ForegroundColor cyan 
            Write-Host "$((($RAM).Capacity | Measure-Object -Sum).Sum/1GB)GB" 
            
            
            Write-Host -ForegroundColor cyan "Disk Space is" 
            $disk
            Write-Host "Built-in RAM" -ForegroundColor cyan
            $RAM | Format-Table Tag,BankLabel,@{n="Capacity(GB)";e={$_.Capacity/1GB}},Manufacturer,PartNumber,Speed -AutoSize  
            

    }
while ($sw.elapsed -lt $timeout)
