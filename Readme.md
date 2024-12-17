# Calculator

by irada prorasri,
673450206-5,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
```

### รับข้อมูล

ตัวอย่าง

```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
int iNum1 = Int32.Parse(inputNum1);
int iNum2 = Int32.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
int iResult = iNum1 + iNum2;  //บวก
```

### แสดงผล

ตัวอย่าง

```
result.Text = iResult.ToString();
```

## ปุ่มลบ
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 - iNum2;
    Result.Text = iResult.ToString();
```
## ปุ่มคูณ
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 * iNum2;
    Result.Text = iResult.ToString();
```
## ปุ่มหาร
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 / iNum2;
    Result.Text = iResult.ToString();
```
## ปุ่มลบข้อมูล
```
private void button3_Click(object sender, EventArgs e)
{
    Num1.Text = "";
    Num2.Text = "";
    Result.Text = "";
}
```