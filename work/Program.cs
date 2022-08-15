using System;
class Script 
{
  static void Main() {
    string[] arr_read = {"hello","2","world",":-)"};
    
    if (arr_read.Length == 0) {
        int arr_length = System.Convert.ToInt32(Console.ReadLine());
        arr_read = new string[arr_length];
        
        for (int i = 0; i < arr_length; i++) {
            arr_read[i] = Console.ReadLine();
        }
    }
    
    string[] arr_write = {};
    int count = 0;
    
    for (int i = 0; i < arr_read.Length; i++) {
        if (arr_read[i].Length <= 3) {
            count += 1;
        }
    }
    
    arr_write = new string[count];
    count = 0;
    
    for (int i = 0; i < arr_read.Length; i++) {
        if (arr_read[i].Length <= 3) {
            arr_write[count] = arr_read[i];
            Console.WriteLine(arr_write[count]);
            count += 1;
        }
    }
  }
}