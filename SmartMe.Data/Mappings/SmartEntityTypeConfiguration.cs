using System.Data.Entity.ModelConfiguration;

namespace SmartMe.Data.Mapping
{
    public abstract class SmartEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected SmartEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}