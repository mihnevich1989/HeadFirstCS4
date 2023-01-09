int myInt = 10;
byte myByte = (byte)myInt;
double myDouble = (double)myByte;
string myString = "false";
myString = myInt.ToString();
short myShort = (short)myInt;
char myChar = 'x';
long myLong = (long)myInt;
decimal myDecimal = (decimal)myLong;
myString = myString + myInt + myByte + myDouble + myChar;

//------------------------------------------------------
Random random = new Random();

int MyMethod(bool add3){
    int value = 12;

	if (add3)
		value += 3;
	else
		value -= 2;
	return value;
}
string t = "test";
int t2 = 2222;
bool agree = true;
MyMethod(agree);

Console.WriteLine((long)t2);
Console.WriteLine((char)t[0]);