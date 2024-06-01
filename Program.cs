using System.Globalization;

class Program{
    static void Main(string[] args) {
        Console.WriteLine("How many iterations?");
        int n = int.Parse(Console.ReadLine() ?? "0");
        string output = "1";
        for(int i = 0; i < n; i++){
            output = next_num(output);
            Console.WriteLine($"{i+2}:{output.Length}");
        }
        Console.WriteLine("Do you want to see the result?");
        if(Console.ReadLine() == "y"){
            Console.WriteLine(output);
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    static string next_num(string num) {
        char current_num = num[0];
        int t = 0;
        string a = String.Empty;
        for(int i = 0; i < num.Length; i++){
            if(current_num == num[i]){
                t++;
            } else{
                a = a + t.ToString() + current_num;
                t = 1;
                current_num = num[i];
            }

        }
        return a + t.ToString() + current_num;
    }
}