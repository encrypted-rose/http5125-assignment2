using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{
    public class j2controller : ApiController
    {/// <summary>
     /// Verifies if input is a word of 30 letters, it's upper case and it contains at least one of the following letters: I, O, S, H, Z, X, and N. Returns a YES or NO response depending on the word inputed.
     /// </summary>
     /// <param name="word"></param>
     /// <returns>If the word can be used or not for a sign that requires the letters above.</returns>
     /// 
        [HttpGet]
        [Route("api/j2controller/sign/{word}")]

        public string sign(string word)
        {
            if (word.Length > 30) && (word.Contains(char.IsUpper)
            {
                return "NO";
            }

            else (word.Contains("I") || (word.Contains("O")) || (word.Contains("S")) || (word.Contains("H")) || (word.Contains("Z")) || (word.Contains("X")) || (word.Contains("N"))
            {
                return "YES";
            }
        }
    }
}


//I'm not completely sure about how to make this happen, I understand I need an IF statement but I'm not sure how to implement the check for upper case and for EACH letter.