// ref: https://www.codewars.com/kata/5208f99aee097e6552000148

public class Kata {
    
    // New solution    
    public static string BreakCamelCase(string str) {
        return string.Join("", str.Select(x => char.IsUpper(x) ? " " + x.ToString() : x.ToString()));
    }     
    
    // An older solution
    public static string BreakCamelCase(string str) {
        var ans = "";
        int i = 0;
        foreach(var ch in str) {
            ans += ch;
            if (i == str.Length - 1) {
                break;
            }
            if (char.IsUpper(str[i + 1])) {
                ans += " ";
            }
  
            ++i;
        }
        
        return ans;
    }
}