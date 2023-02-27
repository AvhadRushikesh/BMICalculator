﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMI.MVVM.Models.BMI BMI { get; set; }
        public BMIViewModel()
        {
            BMI = new Models.BMI();
            BMI.Height = 100;
            BMI.Weight = 73;
        }
    }
}
