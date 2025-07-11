// See https://aka.ms/new-console-template for more information

Console.WriteLine("스파르타 마을에 오신걸 환영합니다. 이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
Console.WriteLine("게임을 시작합니다");
Console.WriteLine("1. 상태보기 / 2. 인벤토리 / 3. 상점");
string menu = Console.ReadLine();

    switch (menu)
    {
        case "1":   
            Console.WriteLine("상태보기");
            break;
        case "2":
            Console.WriteLine("인벤토리");
            break;
        case "3":
            Console.WriteLine("상점");
            break;
        default:
            Console.WriteLine("똑바로 선택해라");
            break;
    }
    
    