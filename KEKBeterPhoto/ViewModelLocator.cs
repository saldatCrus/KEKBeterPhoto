using System;
using System.Collections.Generic;
using System.Text;
using KEKBeterPhoto.ViewModels;
using KEKBeterPhoto.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KEKBeterPhoto
{
    class ViewModelLocator
    {

        private static ServiceProvider _provaider;


        public static void Init()
        {
            var services = new ServiceCollection();

            //My ViewModels
            services.AddTransient<MainViewModel>();
            //services.AddTransient<FirstOpenPageViewModel>();
            //services.AddTransient<FunktionMenuKekPLayerPageViewModel>();
            //services.AddTransient<TrackOnAirPageViewModel>();


            // My service
            services.AddSingleton<NavigationService>();
            //services.AddSingleton<EventBus>();
            //services.AddSingleton<MessageBus>();

            _provaider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provaider.GetRequiredService(item.ServiceType);
            }

        }

        public MainViewModel MainViewModel => _provaider.GetRequiredService<MainViewModel>();

    }
}
