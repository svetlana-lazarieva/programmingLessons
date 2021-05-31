namespace Project2
{
    public abstract class TableBase
    {
        public virtual int Id { get; }

        public abstract void Copy(TableBase otherTable);
    }
}
