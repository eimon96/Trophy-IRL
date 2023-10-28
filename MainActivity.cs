using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace Trophy_IRL{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity{

        private ListView listView;
        private CustomListAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitle(Resource.String.menu_text);
            SetSupportActionBar(toolbar);

            listView = FindViewById<ListView>(Resource.Id.list_view);
            adapter = new CustomListAdapter(TrophyData.Trophies);
            listView.Adapter = adapter;
        }

        public override bool OnCreateOptionsMenu(IMenu menu){
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.add_new){
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
	}
}
