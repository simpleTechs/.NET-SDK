namespace BackendlessAPI.Test.PersistenceService.AsyncEntities.FindEntities
{
  public class FindAllEntityAsync: BaseFindEntityAsync
  {
    public override bool Equals( object obj )
    {
      if( ReferenceEquals( null, obj ) )
        return false;
      if( ReferenceEquals( this, obj ) )
        return true;
      if( obj.GetType() != this.GetType() )
        return false;
      return Equals( (FindAllEntityAsync) obj );
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
