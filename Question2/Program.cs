internal class Program
{
    private static void Main(string[] args)
    {
        string[] countries = new string[5] {"United State","England","Japan","Vietnam","China"};
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
        //Truy cap phan tu trong mang
        Console.WriteLine("----------------------------");
        string selectedCountry = countries[3];
        Console.WriteLine(selectedCountry);
        Console.WriteLine("----------------------------");
        //Xoa phan tu thu 2 trong mang(Do khong the xoa bang phuong thuc RemoveAt() cho nen chung ta se convert cac mang sang kieu du lieu list)
        List<string> countryList = new List<string>(countries);
        countryList.RemoveAt(2);
        countryList.ToArray();
        foreach (var country in countryList)
        {
            Console.WriteLine(country);
        }
        Console.WriteLine("----------------------------");
        //Thay the phan tu
        countryList[3] = "Japan";
        foreach (var country in countryList)
        {
            Console.WriteLine(country);
        }
        Console.WriteLine("----------------------------");
        //Dua ra so phan tu trong mang
        Console.WriteLine(countryList.Count());
        Console.WriteLine("----------------------------");
        //Kiem tra phan tu ban vua nhap co ton tai hay khong
        Console.WriteLine(countryList.Contains("Japan"));
        Console.WriteLine("----------------------------");
        Console.WriteLine(countryList.IndexOf("United State"));
    }
}