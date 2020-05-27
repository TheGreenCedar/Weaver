using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Weaver.Data.Models;

namespace Weaver.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public DbSet<JournalTemplate> Templates { get; set; }
        public DbSet<JournalComponent> JournalComponents { get; set; }

        #region hidden
        protected DbSet<ValueComponent<bool>> BoolValueComponents { get; set; }
        protected DbSet<ValueComponent<string>> StringValueComponents { get; set; }
        protected DbSet<ValueComponent<DateTime>> DateTimeValueComponents { get; set; }
        protected DbSet<ValueComponent<double>> DoubleValueComponents { get; set; }
        protected DbSet<ResizeableComponent<string>> StringResizeableComponents { get; set; }
        protected DbSet<ResizeableComponent<double>> DoubleResizeableComponents { get; set; }
        protected DbSet<JournalGrid> JournalGrids { get; set; }
        protected DbSet<CheckBox> CheckBoxes { get; set; }
        protected DbSet<RadioButton> RadioButtons { get; set; }
        protected DbSet<Toggle> Toggles { get; set; }
        protected DbSet<TextField> TextFields { get; set; }
        protected DbSet<TextArea> TextAreas { get; set; }
        protected DbSet<TextEditor> TextEditors { get; set; }
        protected DbSet<DatePicker> DatePickers { get; set; }
        protected DbSet<FileUploadView> FileUploadViews { get; set; }
        protected DbSet<NumericField> NumericFields { get; set; }
        protected DbSet<SelectField> SelectFields { get; set; }
        protected DbSet<Slider> Sliders { get; set; }
        #endregion
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
