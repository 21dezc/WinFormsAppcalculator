# Calculator

by irada prorasri,
673450206-5,
Computer and Infomation Science, KKU

# ����Ѻ��С���ʴ��Ţ�����

�Ѻ�����Ũҡ�����ҹ ��зӧҹ��ҹ��á��������ͤӹǹ����Ţ

## �����ǡ

```
    // ��ͤ�������ѡ��
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ������������ö�ӡ�� + - * / ��
    int iResult = iNum1 + iNum2;
    // ������ê��� result
    // �դس���ѵԪ��� Text
    result.Text = iResult.ToString();
```

### �Ѻ������

������ҧ

```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
```

### �ŧ��Դ�ͧ������

������ҧ

```
int iNum1 = Int32.Parse(inputNum1);
int iNum2 = Int32.Parse(inputNum2);
```

### �ӹǹ���Ѿ��

������ҧ

```
int iResult = iNum1 + iNum2;  //�ǡ
```

### �ʴ���

������ҧ

```
result.Text = iResult.ToString();
```

## ����ź
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 - iNum2;
    Result.Text = iResult.ToString();
```
## �����ٳ
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 * iNum2;
    Result.Text = iResult.ToString();
```
## �������
```
    string inputNum1 = Num1.Text;
    string inputNum2 = Num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResult = iNum1 / iNum2;
    Result.Text = iResult.ToString();
```
## ����ź������
```
private void button3_Click(object sender, EventArgs e)
{
    Num1.Text = "";
    Num2.Text = "";
    Result.Text = "";
}
```