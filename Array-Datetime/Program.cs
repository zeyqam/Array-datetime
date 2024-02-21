
//Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.
int CountCharacter(string[]array,char character)
{
    
    int totalCount=array.Sum(str=>str.Count(c=>c==character));
    return totalCount;
}
string[] array = { "car", "city", "town", "house", "building" };
char character = 'c';
int count = CountCharacter(array,character);
Console.WriteLine($"'{character} charin arrayin icindeki sayi :{count}");