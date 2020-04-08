import sys,math,re

def check_password_length(password):

        length = str(len(password))
        global password_length_good

        if len (password) < 8:
                print ("[!] Je wachtwoord moet minimaal 8 karakters lang zijn")
                print ("[!] Wachtwoord is maar" ,length, "karakter(s) lang")
                password_length_good = False;
        else:
                print ("[*] Wachtwoord is" ,length, "karakters")
                password_length_good = True;

def check_password_hoofdletter(password):

        global HoofdLetter

        HoofdLetter = len(re.findall(r'[A-Z]',password))

        print ('[*] Je wachtwoord bevat' ,HoofdLetter, 'hoofdletters')

        if HoofdLetter == 1:
                print ('[*] Je wachtwoord bevat 1 hoofdletter') 

        if HoofdLetter == 0:
                print ('[!] Geen hoofdletters in je wachtwoord')

def check_password_nummers(password):

        global getallen
        getallen = len(re.findall(r'[0-9]',password))
        
        print ('[*] Je wachtwoord bevat' ,getallen, 'getallen)')

        if getallen == 1:
                print ('[*] Je wachtwoord bevat 1 getal)')

        if getallen == 0:
                print ('[!] Geen getallen in wachtwoord')

def check_common_passwords(password):

        global matchedPass
        matchedPass = False

        commonPasswords = ['password','welkom','sander','test','admin']

        for commonPass in commonPasswords:

                if commonPass == password:
                        matchedPass = True

        if matchedPass == True:
                print ('[!] Het ingevoerde wachtwoord is een veelvoorkomend wachtwoord')
        else:
                print ('[*] Het ingevoerde wachtwoord is geen veelvoorkomend wachtwoord')

def password_evaluatie(password,password_length_good,HoofdLetter,getallen,matchedPass):

        print ('\n[*] Wachtwoord Evaluatie:')

        if password_length_good == True:
                print ('[*] Wachtwoord is lang genoeg')
        else:
                print ('[*] Wachtwoord is niet lang genoeg')

        if HoofdLetter >=3:
                print ('[*] Je wachtwoord bevat genoeg hoofdletters')
        else:
                print ('[*] Je wachtwoord bevat niet genoeg hoofdletters')

        if getallen >=3:
                print ('[*] Je wachtwoord bevat genoeg getallen')
        else:
                print ('[*] Je wachtwoord bevat niet genoeg getallen')

        if matchedPass == True:
                print ('[!!!] Je wachtwoord is een veelvoorkomend wachtwoord')


        if password_length_good == True and HoofdLetter >=3 and  getallen >=3 and matchedPass == False:
                print ('[*] Je hebt een sterk wachtwoord!')
        else:
                print ('[!!!!!] Je wachtwoord is niet sterk genoeg, pas op het kan een kwetsbaar wachtwoord zijn.')




def main():
        password = input ('Voer een wachtwoord in: ')
        check_password_length(password)
        check_password_hoofdletter(password)
        check_password_nummers(password)
        check_common_passwords(password)
        password_evaluatie(password,password_length_good,HoofdLetter,getallen,matchedPass)


if __name__ == '__main__':
        main()
