string s = "2[abc]3[c8[o]d]ef";

Console.WriteLine(DecodeString(s)); //abcabccdcdcdef

string DecodeString(string s){
    if(s.Contains("[")==true){
        int start = s.LastIndexOf("[");
        int end = s.IndexOf("]",start);
        string sub = s.Substring(start+1,end-start-1);
        string num = "";
        int i = start-1;
        while(i>=0 && Char.IsDigit(s[i])){
            num = s[i]+num;
            i--;
        }
        int n = Int32.Parse(num);
        string temp = "";
        for(int j=0;j<n;j++){
            temp += sub;
        }
        s = s.Substring(0,i+1)+temp+s.Substring(end+1);
        return DecodeString(s);
    }
    return s;
}