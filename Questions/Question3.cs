namespace Questions;

using System;

public class Class1 { // rename Class1 to something meaningful, like FormatChecker. inconsistent use of parenthesis and other formatting issues in file - use auto code cleanup on whole file
    public static bool IsFormat(string str, string f) // rename to IsFormatCorrect
    {
        var allowedDict = new Dictionary<string, bool>()
        { // every value here is mapped to true, so it doesn't have to be dictionary, just usual array with strings
            { "number",true},
            { "date",true},
            { "timespan",true} 
        };

        int isNotAllowed = 0; // naming suggests that it is a bool, yet it is an integer (it should be a bool)
        for (var i = 1; i < allowedDict.Count; i++)
        {
            if (f == allowedDict.Keys.ToArray()[i - 1])
            {
                isNotAllowed |= 1 << i; // unnecessary trick that hurts readability and is never really used in any meaningful way
            }
        } // this whole block could be: bool isNotAllowed = !allowedArray.Contains(f)
        
        if (isNotAllowed > 0)
            throw new Exception("Format not allowed."); // probably unnecessary (unless there are some weird legacy reasons)

        /*
         * whole code above is not needed for this method to work
         * it can be replaced with switch expression:
            return f.ToLower() switch
            {
                "number" => Int32.TryParse(str, out var _),
                "date" => DateTime.TryParse(str, out var _),
                "timespan" => DateTime.TryParse(str, out var _),
                _ => throw new Exception("Unknown format.")
            };
         */
        if (f.ToLower() == "number")
            return Int32.TryParse(str, out var _);
        else if (f.ToLower() == "date")
            return DateTime.TryParse(str, out var _);
        else if (f.ToLower() == "timespan")
            return DateTime.TryParse(str, out var _);

        throw new Exception("Unknown format.");
    }

}
