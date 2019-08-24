using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xfw.Models;

namespace Xfw.Services
{
    public class UpComingResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }

    }
}
