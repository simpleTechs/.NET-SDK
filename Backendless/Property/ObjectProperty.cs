﻿using Weborb.Service;

namespace BackendlessAPI.Property
{
  public class ObjectProperty : AbstractProperty
  {
    public ObjectProperty()
    {
    }

    public ObjectProperty( string name )
    {
      Name = name;
    }

    public ObjectProperty( string name, DateTypeEnum type, bool required )
    {
      Name = name;
      Type = type;
      IsRequired = required;
    }

    [SetClientClassMemberName( "relatedTable" )]
    public string RelatedTable { get; set; }
  }
}