using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chapter4_DependencyProperties.Examples {
    public class DependencyPropertyTest : FrameworkElement {
        public static readonly DependencyProperty MarginProperty;

        public DependencyPropertyTest() {
            MarginProperty = DependencyProperty.Register("Margin", typeof(Thickness), new FrameworkElement(), new FrameworkPropertyMetadata(default(Thickness), FrameworkPropertyMetadataOptions.AffectsMeasure), null);
        }
    }
}
