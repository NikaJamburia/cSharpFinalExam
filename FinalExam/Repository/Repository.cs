using Spring.Objects.Factory.Attributes;
using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalExam.Repository
{
    [Component]
    public abstract class Repository
    {
        protected EFContext Context = new EFContext();
    }
}