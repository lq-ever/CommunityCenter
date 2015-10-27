using System;
using Android.Widget;
using Android.App;
using Android.Views;
using CommunityCenter.Model;
using CommunityCenter;

namespace CommunityCenter.Adapter
{
	public class AdviceRecordListAdapter:ArrayAdapter<AdviceRecordInfoItem>
	{
		private Activity activity;
		public AdviceRecordListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			AdviceRecordItemView _adviceRecordItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.AdviceRecordListItemView, null);
				_adviceRecordItemView = new AdviceRecordItemView ();
				_adviceRecordItemView.img_adviceType = convertView.FindViewById<ImageView> (Resource.Id.img_adviceType);
				_adviceRecordItemView.tv_adviceTitle = convertView.FindViewById<TextView> (Resource.Id.tv_adviceTitle);
				_adviceRecordItemView.tv_adviceTime = convertView.FindViewById<TextView> (Resource.Id.tv_adviceTime);
				_adviceRecordItemView.tv_adviceContent = convertView.FindViewById<TextView> (Resource.Id.tv_adviceContent);
				convertView.SetTag (Resource.Id.advicelistitemview, _adviceRecordItemView);

			} else
				_adviceRecordItemView = (AdviceRecordItemView)convertView.GetTag (Resource.Id.advicelistitemview);

			_adviceRecordItemView.img_adviceType.SetImageResource(GetAdviceTypeId(item.MessageType));
			_adviceRecordItemView.tv_adviceTime.Text =  string.IsNullOrEmpty(item.MessageTime)?string.Empty: Convert.ToDateTime( item.MessageTime).ToString("yyyy-MM-dd HH:mm:ss");
			_adviceRecordItemView.tv_adviceTitle.Text = string.IsNullOrEmpty(item.MessageTitle)?string.Empty:item.MessageTitle;
			_adviceRecordItemView.tv_adviceContent.Text = string.IsNullOrEmpty(item.MessageContent)?string.Empty:item.MessageContent;
			return convertView;
		}
		/// <summary>
		/// 获取建议类型Id
		/// </summary>
		/// <returns>The advice type identifier.</returns>
		/// <param name="adviceType">Advice type.</param>
		private int GetAdviceTypeId(string adviceType)
		{
			int adviceId;
			switch ((AdviceType)Convert.ToInt16(adviceType)) {
			case AdviceType.Consult:
				adviceId = Resource.Drawable.ic_myInfo_advision_zixun;
				break;
			case AdviceType.Suggest:
				adviceId = Resource.Drawable.ic_myInfo_advision_jianyi;
				break;
			case AdviceType.Complain:
				adviceId = Resource.Drawable.ic_myInfo_advision_tousu;
				break;
			case AdviceType.Other:
				adviceId = Resource.Drawable.ic_myInfo_advision_qita;
				break;
			default:
				adviceId = Resource.Drawable.ic_myInfo_advision_zixun;
				break;
				
			}
			return adviceId;
		}


	}



	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class AdviceRecordItemView:Java.Lang.Object
	{
		public ImageView img_adviceType;
		public TextView tv_adviceTitle;
		public TextView tv_adviceTime;	
		public TextView tv_adviceContent;

	}
}

