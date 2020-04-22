using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
#nullable enable
namespace Weaver.Data.Models
{
    #region abstracts
    public abstract class JournalComponent
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; } = "";
        public int Row { get; set; }
        public int Col { get; set; }
        public JournalGrid? Parent { get; set; }
    }
    public abstract class ValueComponent<T> : JournalComponent
    {
        public string Value { get; set; } = "";
        [NotMapped]
        public virtual T MappedValue
        {
            get => JsonSerializer.Deserialize<T>(Value);
            set { Value = JsonSerializer.Serialize(value); }
        }
    }
    public abstract class ResizeableComponent<T> : ValueComponent<T>
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public bool FullWidth { get; set; } = true;
        public bool FullHeight { get; set; }
    }
    #endregion abstracts
    public class JournalGrid : JournalComponent
    {
        public virtual List<JournalComponent> Children { get; set; } = new List<JournalComponent>();
    }
    public class CheckBox : ValueComponent<bool>
    {
    }
    public class RadioList: JournalComponent
    {
        public virtual List<RadioButton> Buttons { get; set; } = new List<RadioButton>();
    }
    public class RadioButton : ValueComponent<bool>
    {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public RadioList ParentList { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
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
    public class SelectField : ValueComponent<List<string>>
    {
        public bool Multi { get; set; } = false;
        public string Options { get; set; } = "";
        [NotMapped]
        public virtual List<string> OptionsList
        {
            get => JsonSerializer.Deserialize<List<string>>(this.Options);
            set { this.Options = JsonSerializer.Serialize(value); }
        }
    }
    public class Slider : ResizeableComponent<double>
    {
        public double Step { get; set; } = 1;
        public double Min { get; set; } = 0;
        public double Max { get; set; } = 100;
    }
}
