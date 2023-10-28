using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Trophy_IRL{
    [Activity(Label = "CreateTrophyActivity", Theme = "@style/AppTheme.NoActionBar")]
    public class CreateTrophyActivity : AppCompatActivity{

        private EditText title;
        private EditText description;
        private Spinner dropdown;
        private ArrayAdapter<string> adapter;
        private Button unlock;

        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_trophy_create);

            InitToolbar();
            InitReferences();
            PopulateSpinner();
        }

        public override bool OnOptionsItemSelected(IMenuItem item){
            if (item.ItemId == Android.Resource.Id.Home)
                Finish();

            return base.OnOptionsItemSelected(item);
        }

        private void InitToolbar(){
            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitle(Resource.String.menu_text2);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
        }

        private void InitReferences(){
            title = FindViewById<EditText>(Resource.Id.EdTitle);
            description = FindViewById<EditText>(Resource.Id.EdDescription);
            dropdown = FindViewById<Spinner>(Resource.Id.SpType);
            unlock = FindViewById<Button>(Resource.Id.BtnUnlock);
            unlock.Click += (sender, e) =>{
                TrophyData.AddTrophy(dropdown.SelectedItem.ToString().ToLower(), title.Text, description.Text);
                MainActivity.UpdateList();
                Finish();
            };
        }

        private void PopulateSpinner(){
            string[] types = new string[] { "Bronze", "Silver", "Gold", "Platinum" };
            adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, types);
            adapter.SetDropDownViewResource(Resource.Layout.spinner_item);
            dropdown.Adapter = adapter;
        }
    }
}