using System;
using System.Xml.Serialization;

namespace SimpleSolution.Data.ModelsBase
{
    [Serializable]

    public class EntityBase
    {
        public EntityBase()
        {
            CreateDate = DateTime.Now;
        }

        [XmlIgnore]
        public DateTime? CreateDate { get; set; }

        [XmlIgnore]
        public DateTime? ModifyDate { get; set; }
    }
}
