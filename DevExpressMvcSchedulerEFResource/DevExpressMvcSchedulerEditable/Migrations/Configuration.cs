namespace DevExpressMvcSchedulerEditable.Migrations
{
    using DevExpressMvcSchedulerEF;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DevExpressMvcSchedulerEF.Views.SchedulerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DevExpressMvcSchedulerEF.Views.SchedulerContext context)
        {
            EFResource res1 = new EFResource();
            res1.ResourceID = 1;
            res1.ResourceName = "Resource1";
            context.EFResources.Add(res1);
            res1.Color = System.Drawing.Color.DarkOrange.ToArgb();

            EFResource res2 = new EFResource();
            res2.ResourceID = 2;
            res2.ResourceName = "Resource2";
            res2.Color = System.Drawing.Color.SteelBlue.ToArgb();
            context.EFResources.Add(res2);
        }
    }
}
