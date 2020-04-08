#include <Keyboard.h> 

// Init function
void setup()
{
  // Begining the stream
  Keyboard.begin();

  // Waiting 500ms for init
  delay(500);

  delay(3000);

  Keyboard.press(KEY_LEFT_GUI);
  Keyboard.press(114);
  Keyboard.releaseAll();

  delay(500);

  Keyboard.print("notepad");

  delay(500);

  typeKey(KEY_RETURN);

  delay(750);

  Keyboard.print("Dit is een Rubber Ducky Test Script!");

  typeKey(KEY_RETURN);
}

void typeKey(int key)
{
  Keyboard.press(key);
  delay(50);
  Keyboard.release(key);
}

// Unused
void loop() {}
