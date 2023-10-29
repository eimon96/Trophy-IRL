using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Trophy_IRL{
    internal class CustomListAdapter : BaseAdapter<Trophy>{
        private List<Trophy> trophies;

        public CustomListAdapter(List<Trophy> trophies){
            this.trophies = trophies;
        }

        public void Add(Trophy trophy){
            trophies.Insert(0, trophy);
        }

        public void Remove(int position)
        {
            trophies.RemoveAt(position);
        }

        public override Trophy this[int position]{
            get{
                return trophies[position];
            }
        }

        public override int Count{
            get{
                return trophies.Count;
            }
        }

        public override long GetItemId(int position){
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent){
            var view = convertView;

            if (view == null){
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_item, parent, false);

                var icon = view.FindViewById<ImageView>(Resource.Id.icon);
                var title = view.FindViewById<TextView>(Resource.Id.title);
                var description = view.FindViewById<TextView>(Resource.Id.description);

                view.Tag = new ViewHolder() { Icon = icon, Title = title, Description = description };
            }

            var holder = (ViewHolder)view.Tag;

            holder.Icon.SetImageResource(trophies[position].Icon);
            holder.Title.Text = trophies[position].Title;
            holder.Description.Text = trophies[position].Description;

            return view;
        }
    }
}