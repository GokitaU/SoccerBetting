﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SoccerBetting.Models
{
    public class Team : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}