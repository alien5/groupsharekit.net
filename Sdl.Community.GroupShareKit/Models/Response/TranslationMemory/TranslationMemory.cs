﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.GroupShareKit.Models.Response.TranslationMemory
{
    public class TranslationMemory
    {
        /// <summary>
        /// Gets or sets translation memory number
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets translation translation memory list
        /// </summary>
        public List<TranslationMemoryDetails> Items { get; set; }

        /// <summary>
        /// Gets or sets next page link
        /// </summary>
        public string NextPageLink { get; set; }
    }
}
