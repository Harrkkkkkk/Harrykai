using System;
using System.Timers; // 确保使用 System.Timers.Timer

public class AlarmClock
{
    private System.Timers.Timer timer; // 使用 System.Timers.Timer
    private DateTime alarmTime;

    // 嘀嗒事件
    public event Action Tick;
    // 响铃事件
    public event Action Alarm;

    public AlarmClock()
    {
        timer = new System.Timers.Timer(1000); // 每秒触发一次
        timer.Elapsed += OnTick;  // 订阅计时器的 Elapsed 事件
    }

    // 启动闹钟
    public void Start(DateTime alarmTime)
    {
        this.alarmTime = alarmTime;
        timer.Start();
    }

    // 停止闹钟
    public void Stop()
    {
        timer.Stop();
    }

    // 计时器触发时的处理方法
    private void OnTick(object sender, ElapsedEventArgs e)
    {
        Tick?.Invoke(); // 触发嘀嗒事件

        if (DateTime.Now >= alarmTime)
        {
            Alarm?.Invoke(); // 触发响铃事件
            Stop(); // 停止计时器
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var alarmClock = new AlarmClock();

        // 订阅嘀嗒事件
        alarmClock.Tick += () => Console.WriteLine("嘀嗒...");

        // 订阅响铃事件
        alarmClock.Alarm += () => Console.WriteLine("闹钟响铃！时间到了！");

        // 输入设定的时间
        Console.WriteLine("请输入设定的时间（格式：HH:mm:ss）：");
        string input = Console.ReadLine();

        // 解析用户输入的时间
        TimeSpan alarmTimeSpan;
        if (TimeSpan.TryParse(input, out alarmTimeSpan))
        {
            // 设置闹钟时间为当前时间加上用户输入的时间
            DateTime alarmTime = DateTime.Now.Date.Add(alarmTimeSpan);
            if (alarmTime <= DateTime.Now) // 如果设定时间在当前时间之前，则加一天
            {
                alarmTime = alarmTime.AddDays(1);
            }

            Console.WriteLine($"闹钟设置在: {alarmTime}");
            alarmClock.Start(alarmTime);
        }
        else
        {
            Console.WriteLine("输入的时间格式不正确，请使用 HH:mm:ss 格式。");
            return;
        }

        // 保持主线程运行，直到闹钟响铃
        Console.WriteLine("按下任意键停止闹钟...");
        Console.ReadKey();
    }
}
