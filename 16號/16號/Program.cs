using System;

namespace _16號
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!來接你了唷");
            // Console.Read();

            // 輸入身高和體重
            Console.Write("請輸入體重 (公斤): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入身高 (公尺): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // 計算BMI
            double bmi = weight / (height * height);

            // 輸出BMI結果
            Console.WriteLine($"你的BMI值是: {bmi:F2}");

            // 根據BMI值提供健康建議
            if (bmi < 18.5)
            {
                Console.WriteLine("偏瘦，請注意飲食和營養攝取。");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("正常範圍，保持健康的生活方式！");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("過重，建議注意飲食和運動。");
            }
            else
            {
                Console.WriteLine("肥胖，建議尋求專業健康建議。");
            }

            // 暫停以查看結果
            Console.ReadLine();
        }
    }
}
