﻿using Autofac;
using Microsoft.Bot.Builder.Dialogs;
using System;

namespace Crm.SampleBot.Dialogs
{
    public sealed class DialogFactory
    {
        private IComponentContext componentContext;

        public DialogFactory(IComponentContext componentContext)
        {
            this.componentContext = componentContext;
        }

        public IDialog<object> Create<TDialog>() where TDialog : IDialog<object>
        {
            return componentContext.Resolve<TDialog>();
        } 
    }
}
