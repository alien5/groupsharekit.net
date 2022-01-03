﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sdl.Community.GroupShareKit.Models.Response.TranslationMemory
{
    public class Settings
    {
        /// <summary>
        /// Gets or sets if it supports acronymus autosubstitution
        /// </summary>
        public bool AcronymsAutoSubstitution { get; set; }
        /// <summary>
        /// Gets or sets if it should check matching sublanguages
        /// </summary>
        public bool CheckMatchingSublanguages { get; set; }

        /// <summary>
        /// Gets or sets confirmation levels
        /// </summary>

        public List<string> ConfirmationLevels { get; set; }


        /// <summary>
        /// Gets or sets existing tus update mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public UpdateMode ExistingTUsUpdateMode { get; set; }

        /// <summary>
        /// Gets or sets existing fields update mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ExistingFieldsMode ExistingFieldsUpdateMode { get; set; }

        /// <summary>
        /// Gets or sets new fields behaviour
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FieldsBehaviour NewFieldsBehaviour { get; set; }

        /// <summary>
        /// Gets or sets tu processing mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProccesingMode TuProcessingMode { get; set; }

        /// <summary>
        /// Gets or sets field values
        /// </summary>
        public List<FieldValue> FieldValues { get; set; }

        public enum ProccesingMode
        {
            ProcessRawTUOnly,
            ProcessCleanedTUOnly,
            ProcessBothTUs
        }
        public enum FieldsBehaviour
        {
            AddToSetup,
            Ignore,
            SkipTranslationUnit,
            Error
        }
        public enum ExistingFieldsMode
        {
            Merge, //this is the default
            Overwrite,
            LeaveUnchanged
        }
        public enum UpdateMode
        {
            AddNew,
            Overwrite,
            LeaveUnchanged,
            KeepMostRecent,
            OverwriteCurrent

        }

    }
}
