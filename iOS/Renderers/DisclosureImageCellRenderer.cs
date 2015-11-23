using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Mono;
using UIKit;
using XamarinDemo.iOS;
using XamarinDemo;

// This Custom Renderer will add Disclosure ">" indicators to ImageCells.
[assembly: ExportRendererAttribute(typeof(DisclosureImageCell), typeof(DisclosureImageCellRenderer))]
namespace XamarinDemo.iOS
{
	public class DisclosureImageCellRenderer: ImageCellRenderer
	{
		// Get the cell and add the disclosure indicator if the bindable property was set to true.
		public override UITableViewCell GetCell (Cell item,  UITableViewCell reusableCell, UITableView tv){
			var cell = base.GetCell (item, reusableCell, tv);
			if( ( (DisclosureImageCell) item ).DisclosureEnabled)
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return cell;
		}
	}
}

