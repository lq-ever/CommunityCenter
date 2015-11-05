using System;
using Android.Widget;
using CommunityCenter.Model.Finance;
using Android.App;
using Android.Views;
using CommunityCenter.Common;

namespace CommunityCenter.Adapter
{
	public class BankCardInfoListAdapter:ArrayAdapter<BankCardItem>
	{
		private Activity activity;

		public BankCardInfoListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			BankItemView _bankItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.BankCardlListitemView, null);
				_bankItemView = new BankItemView ();
				_bankItemView.img_bank = convertView.FindViewById<ImageView> (Resource.Id.img_bank);
				_bankItemView.tv_bankNo = convertView.FindViewById<TextView> (Resource.Id.tv_bankNo);
				convertView.SetTag (Resource.Id.bankitemview, (Java.Lang.Object)_bankItemView);

			} else
				_bankItemView = (BankItemView)convertView.GetTag (Resource.Id.bankitemview);
			//赋值
			Global.imageLoader.DisplayImage(item.BankCardImageUrl,_bankItemView.img_bank,Global.Options);
			_bankItemView.tv_bankNo.Text = !string.IsNullOrEmpty (item.BankCardNo) ? item.BankCardNo : string.Empty;//todo将卡号前面用*隐藏
			return convertView;
		}
	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class BankItemView:Java.Lang.Object
	{
		public ImageView img_bank;
		public TextView tv_bankNo;
	}
}

