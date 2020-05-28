using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#pragma warning disable CA2227 // Collection properties should be read only
namespace Weaver.Data.Models
{
    public enum CLayout {
        Horizontal = 0,
        Vertical
    }

    #region abstracts
    public abstract class JournalComponent
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; } = "";
        public int Row { get; set; }
        public int Col { get; set; }
        [JsonIgnore]
        public JournalGrid? Parent { get; set; }
    }
    public abstract class ValueComponent<T> : JournalComponent
    {
        public string Value { get; set; } = String.Empty;

        [NotMapped, JsonIgnore]
        protected static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            TypeNameHandling = TypeNameHandling.None,
            MaxDepth = 15,
        };

        [NotMapped, JsonIgnore]
        public virtual T MappedValue
        {
            get => typeof(T) == typeof(string)
                        ? (T)(object)Value
                        : JsonConvert.DeserializeObject<T>(Value, SerializerSettings);
            set
            {
                Value = value switch
                {
                    string s => s,
                    _ => JsonConvert.SerializeObject(value, SerializerSettings) ?? String.Empty
                };
            }
        }
    }
    public abstract class ResizeableComponent<T> : ValueComponent<T>
    {
        public float Height { get; set; }
    }
    #endregion abstracts
    public class JournalGrid : JournalComponent
    {
        public virtual List<JournalComponent> Children { get; set; } = new List<JournalComponent>();
    }
    public class CheckBox : ValueComponent<bool>
    {
    }
    public class RadioList : ValueComponent<string>
    {
        public virtual List<string> Buttons { get; set; } = new List<string>();
        public CLayout Layout { get; set; } = CLayout.Horizontal;
    }
    public class Toggle : ValueComponent<bool>
    {
    }
    public class TextField : ValueComponent<string>
    {
    }
    public class TextArea : ResizeableComponent<string>
    {
    }
    public class TextEditor : TextArea
    {
    }
    public class DatePicker : ValueComponent<DateTime>
    {
        public bool EnableTime { get; set; } = false;
    }
    public class FileUploadView : ValueComponent<string>
    {
        public bool IsImageViewer { get; set; } = true;
    }
    public enum NumericType
    {
        Numeric,
        Currency,
        Percent
    }
    public class NumericField : ValueComponent<double>
    {
        public short DecimalPlaces { get; set; } = 0;
        public NumericType FieldType { get; set; } = NumericType.Numeric;
        public double Step { get; set; } = 1;
    }
    public class SelectField : ValueComponent<string>
    {
        public bool Multi { get; set; } = false;
        public string Options { get; set; } = String.Empty;
        [NotMapped, JsonIgnore]
        public virtual List<string> OptionsList
        {
            get => JsonConvert.DeserializeObject<List<string>>(this.Options, SerializerSettings) ?? new List<string>();
            set
            {
                this.Options = JsonConvert.SerializeObject(value, SerializerSettings);
            }
        }
    }
    public class Slider : ValueComponent<double>
    {
        public double Step { get; set; } = 1;
        public double Min { get; set; } = 0;
        public double Max { get; set; } = 100;
    }
}
#pragma warning restore CA2227 // Collection properties should be read only
