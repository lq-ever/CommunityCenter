using System;
using System.Collections.Generic;

using Android.Support.V4.App;


namespace CommunityCenter.Adapter
{
	public class ViewFragmentPagerAdapter:FragmentPagerAdapter
	{
		List<Fragment> fragments;



		public ViewFragmentPagerAdapter (List<Fragment> _fragments,FragmentManager fm):base(fm)
		{
			fragments = _fragments;

		}

		public override int Count {
			get {
				return fragments.Count;
			}
		}

		public override Fragment GetItem(int position)
		{
			return fragments[position];
		}

		public override int GetItemPosition (Java.Lang.Object objectValue)
		{
			return base.GetItemPosition (objectValue);
		}
	}
}

