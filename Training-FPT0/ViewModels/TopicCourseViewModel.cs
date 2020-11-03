﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training_FPT0.Models;

namespace Training_FPT0.ViewModels
{
    public class TopicCourseViewModel
    {
        public Topic Topic { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}