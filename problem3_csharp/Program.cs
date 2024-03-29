// See https://aka.ms/new-console-template for more information


if(LengthOfLongestSubstring("abcabcbb") != 3){
    Console.WriteLine("NO " + LengthOfLongestSubstring("abcabcbb"));
}
else{
    Console.WriteLine("SI");
}
if(LengthOfLongestSubstring("bbbbb") != 1){
    Console.WriteLine("NO " + LengthOfLongestSubstring("bbbbb"));
}
else{Console.WriteLine("SI");}
if(LengthOfLongestSubstring("pwwkew") != 3){
    Console.WriteLine("NO " + LengthOfLongestSubstring("pwwkew"));
}
else{
    Console.WriteLine("SI");
}

if(LengthOfLongestSubstring(" ") != 1){
    Console.WriteLine("NO " + LengthOfLongestSubstring(" "));
}
else{
    Console.WriteLine("SI");
}

if(LengthOfLongestSubstring("au") != 2){
    Console.WriteLine("NO " + LengthOfLongestSubstring("au"));
}
else{
    Console.WriteLine("SI");
}

if(LengthOfLongestSubstring("aabaab!bb") != 3){
    Console.WriteLine("NO " + LengthOfLongestSubstring("aabaab!bb"));
}
else{
    Console.WriteLine("SI");
}

if(LengthOfLongestSubstring("dvdf") != 3){
    Console.WriteLine("NO " + LengthOfLongestSubstring("dvdf"));
}
else{
    Console.WriteLine("SI");
}

if(LengthOfLongestSubstring("anviaj") != 5){
    Console.WriteLine("NO " + LengthOfLongestSubstring("anviaj"));
}
else{
    Console.WriteLine("SI");
}

var muyLargo = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ aqui iba un texto más largo rstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ abcdefghijklmnopqrstuvwxyzABCD";
var ahora = DateTime.Now;
LengthOfLongestSubstring(muyLargo);
Console.WriteLine(new TimeSpan(DateTime.Now.Ticks - ahora.Ticks));

    int LengthOfLongestSubstring(string s)
    {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int max = 1;
        for (int i = 0; i < s.Length; i++){
           
            if(s.Length - i < max){
                return max;
            }

            var subActual = s.Substring(i, max);
            var hash = new HashSet<char>(subActual);

            for(int j = hash.Count; i + j < s.Length; j++){
                hash.Add(s[j + i]);
                //var actual = new string(hash.ToArray());

                if(j + 1 == hash.Count){
                    max = Math.Max(j + 1, max);
                }
                else{
                    j = s.Length + 1;
                }
            }

        }

        return max;
    }
