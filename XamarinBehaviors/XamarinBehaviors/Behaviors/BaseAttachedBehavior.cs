using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace XamarinBehaviors.Behaviors
{
    public abstract class BaseAttachedBehavior<TBehavior, TBindable> : Behavior<TBindable> where TBindable : BindableObject
    {
        public static readonly BindableProperty AttachBehaviorProperty = BindableProperty.CreateAttached("AttachBehavior",
                                                                                            typeof(bool),
                                                                                            typeof(TBehavior),
                                                                                            false,
                                                                                            propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, object newValue)
        {
            view.SetValue(AttachBehaviorProperty, (bool)newValue);
        }


        private static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            if(view is View)
            {
                var behavior = ((View)view).Behaviors.FirstOrDefault(b => b is TBehavior);

                if((bool)newValue)
                {
                    if(behavior == null)
                    {
                        ((View)view).Behaviors.Add(Activator.CreateInstance<TBehavior>() as Behavior);
                    }
                }
                else
                {
                    if(behavior != null)
                    {
                        ((View)view).Behaviors.Remove(behavior);
                    }
                }
            }
        }
    }
}
