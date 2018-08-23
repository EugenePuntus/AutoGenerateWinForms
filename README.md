# AutoGenerateWinForms
Auto create WinForm for class with attributes «FormControlAttribute»

## How to use
```c#

    class Program
    {
        static void Main(string[] args)
        {
            var winFormGenerated = new WinFormGenerating();
            var exemplar = new ExampleFormGenerating()
            {
                MyBool = true,
                MyNumber = 10,
                MyNumber2 = 99.20m,
                MyString = "Тестовая строка"
            };

            var form = winFormGenerated.GetForm(exemplar);
            form.ShowDialog();

            Console.WriteLine(exemplar.Result);
        }
    }

    public class ExampleFormGenerating
    {
        [FormControl(Type = FormControlType.TextBox, LabelText = "Number Int")]
        public int MyNumber { get; set; }

        [FormControl(Type = FormControlType.TextBox, LabelText = "Number Decimal")]
        public decimal MyNumber2 { get; set; }

        [FormControl(Type = FormControlType.TextBox, LabelText = "String")]
        public string MyString { get; set; }

        [FormControl(Type = FormControlType.ComboBox, LabelText = "Bool", DataSourse = new[] {true,false})]
        public bool MyBool { get; set; }

        public string Result => $"{MyNumber} | {MyNumber2} | {MyString} | {MyBool}";
    }

```

### The generated form and result in the console

![alt text](https://github.com/PuntusEugene/AutoGenerateWinForms/blob/master/Image/generated_form.png)

![alt text](https://github.com/PuntusEugene/AutoGenerateWinForms/blob/master/Image/result_refresh.png)
