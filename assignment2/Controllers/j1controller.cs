using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{
    public class j1controller : ApiController
    {

        /// <summary>
        /// Receives number of treats Barley the dog is receiving in numbers, which are measured in a scoring system (1 * small + 2 * medium + 3 * large)
        /// Returns if Barley the dog is happy or sad with the amount of treats.
        /// </summary>
        /// <param name="small">the amount of small treats given to Barley</param>
        /// <param name="medium">the amount of medium treats given to Barley</param>
        /// <param name="large">the amount of large treats ggiven to Barley</param>
        /// <returns> The status of the dog, either happy or sad, after calculating the score of the amount of treats they were given. </returns>
        /// <example>Get api/j1controller/dogtreat/1/2/4 -> Happy!</example>
        /// <example>Get api/j1controller/dogtreat/0/1/2 -> Sad :( </example>

        [HttpGet]
        [Route("api/j1controller/DogTreat/{small}/{medium}/{large}")]

        public string DogTreat(int small, int medium, int large)
        {
            int var1 = 1 * small;
            int var2 = 2 * medium;
            int var3 = 3 * large;

            if (var1 + var2 + var3 >= 10) {
                return "Happy!";
            }

            else
            {
                return "Sad :(";
            }

   
        }
    }
}
