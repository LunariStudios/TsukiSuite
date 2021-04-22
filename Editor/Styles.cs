#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace Lunari.Tsuki.Editor {
    public static class Styles {
        public static GUIStyle Get(string key, EditorSkin skin = EditorSkin.Inspector) {
            return EditorGUIUtility.GetBuiltinSkin(skin).FindStyle(key);
        }

        public static GUIStyle box => Keys.box;
        public static GUIStyle button => Keys.button;
        public static GUIStyle toggle => Keys.toggle;
        public static GUIStyle label => Keys.label;
        public static GUIStyle window => Keys.window;
        public static GUIStyle textfield => Keys.textfield;
        public static GUIStyle textarea => Keys.textarea;
        public static GUIStyle horizontalslider => Keys.horizontalslider;
        public static GUIStyle horizontalsliderthumb => Keys.horizontalsliderthumb;
        public static GUIStyle verticalslider => Keys.verticalslider;
        public static GUIStyle verticalsliderthumb => Keys.verticalsliderthumb;
        public static GUIStyle horizontalscrollbar => Keys.horizontalscrollbar;
        public static GUIStyle horizontalscrollbarthumb => Keys.horizontalscrollbarthumb;
        public static GUIStyle horizontalscrollbarleftbutton => Keys.horizontalscrollbarleftbutton;
        public static GUIStyle horizontalscrollbarrightbutton => Keys.horizontalscrollbarrightbutton;
        public static GUIStyle verticalscrollbar => Keys.verticalscrollbar;
        public static GUIStyle verticalscrollbarthumb => Keys.verticalscrollbarthumb;
        public static GUIStyle verticalscrollbarupbutton => Keys.verticalscrollbarupbutton;
        public static GUIStyle verticalscrollbardownbutton => Keys.verticalscrollbardownbutton;
        public static GUIStyle scrollview => Keys.scrollview;
        public static GUIStyle AboutWIndowLicenseLabel => Keys.AboutWIndowLicenseLabel;
        public static GUIStyle AC_BoldHeader => Keys.AC_BoldHeader;
        public static GUIStyle AC_Button => Keys.AC_Button;
        public static GUIStyle AC_ComponentButton => Keys.AC_ComponentButton;
        public static GUIStyle AC_GroupButton => Keys.AC_GroupButton;
        public static GUIStyle AC_LeftArrow => Keys.AC_LeftArrow;
        public static GUIStyle AC_PreviewHeader => Keys.AC_PreviewHeader;
        public static GUIStyle AC_PreviewText => Keys.AC_PreviewText;
        public static GUIStyle AC_RightArrow => Keys.AC_RightArrow;
        public static GUIStyle AM_ChannelStripHeaderStyle => Keys.AM_ChannelStripHeaderStyle;
        public static GUIStyle AM_EffectName => Keys.AM_EffectName;
        public static GUIStyle AM_HeaderStyle => Keys.AM_HeaderStyle;
        public static GUIStyle AM_MixerHeader => Keys.AM_MixerHeader;
        public static GUIStyle AM_MixerHeader2 => Keys.AM_MixerHeader2;
        public static GUIStyle AM_ToolbarLabel => Keys.AM_ToolbarLabel;
        public static GUIStyle AM_ToolbarObjectField => Keys.AM_ToolbarObjectField;
        public static GUIStyle AM_TotalVuLabel => Keys.AM_TotalVuLabel;
        public static GUIStyle AM_VuValue => Keys.AM_VuValue;
        public static GUIStyle AnimationEventBackground => Keys.AnimationEventBackground;
        public static GUIStyle AnimationEventTooltip => Keys.AnimationEventTooltip;
        public static GUIStyle AnimationEventTooltipArrow => Keys.AnimationEventTooltipArrow;
        public static GUIStyle AnimationKeyframeBackground => Keys.AnimationKeyframeBackground;
        public static GUIStyle AnimationPlayHead => Keys.AnimationPlayHead;
        public static GUIStyle AnimationRowEven => Keys.AnimationRowEven;
        public static GUIStyle AnimationRowOdd => Keys.AnimationRowOdd;
        public static GUIStyle AnimationSelectionTextField => Keys.AnimationSelectionTextField;
        public static GUIStyle AnimationTimelineTick => Keys.AnimationTimelineTick;
        public static GUIStyle AnimClipToolbar => Keys.AnimClipToolbar;
        public static GUIStyle AnimClipToolbarButton => Keys.AnimClipToolbarButton;
        public static GUIStyle AnimClipToolbarPopup => Keys.AnimClipToolbarPopup;
        public static GUIStyle AnimItemBackground => Keys.AnimItemBackground;
        public static GUIStyle AnimLeftPaneSeparator => Keys.AnimLeftPaneSeparator;
        public static GUIStyle AnimPlayToolbar => Keys.AnimPlayToolbar;
        public static GUIStyle AnimPropDropdown => Keys.AnimPropDropdown;
        public static GUIStyle AppCommand => Keys.AppCommand;
        public static GUIStyle AppCommandLeft => Keys.AppCommandLeft;
        public static GUIStyle AppCommandLeftOn => Keys.AppCommandLeftOn;
        public static GUIStyle AppCommandMid => Keys.AppCommandMid;
        public static GUIStyle AppCommandRight => Keys.AppCommandRight;
        public static GUIStyle AppToolbar => Keys.AppToolbar;
        public static GUIStyle AppToolbarButtonLeft => Keys.AppToolbarButtonLeft;
        public static GUIStyle AppToolbarButtonMid => Keys.AppToolbarButtonMid;
        public static GUIStyle AppToolbarButtonRight => Keys.AppToolbarButtonRight;
        public static GUIStyle ArrowNavigationLeft => Keys.ArrowNavigationLeft;
        public static GUIStyle ArrowNavigationRight => Keys.ArrowNavigationRight;
        public static GUIStyle AssetLabel => Keys.AssetLabel;
        public static GUIStyle AssetLabel_Icon => Keys.AssetLabel_Icon;
        public static GUIStyle AssetLabel_Partial => Keys.AssetLabel_Partial;
        public static GUIStyle AvatarMappingBox => Keys.AvatarMappingBox;
        public static GUIStyle AvatarMappingErrorLabel => Keys.AvatarMappingErrorLabel;
        public static GUIStyle AxisLabelNumberField => Keys.AxisLabelNumberField;
        public static GUIStyle Badge => Keys.Badge;
        public static GUIStyle BoldLabel => Keys.BoldLabel;
        public static GUIStyle BoldTextField => Keys.BoldTextField;
        public static GUIStyle BoldToggle => Keys.BoldToggle;
        public static GUIStyle BottomShadowInwards => Keys.BottomShadowInwards;
        public static GUIStyle BreadcrumbsSeparator => Keys.BreadcrumbsSeparator;
        public static GUIStyle ButtonLeft => Keys.ButtonLeft;
        public static GUIStyle ButtonMid => Keys.ButtonMid;
        public static GUIStyle ButtonRight => Keys.ButtonRight;
        public static GUIStyle BypassToggle => Keys.BypassToggle;
        public static GUIStyle CacheFolderLocation => Keys.CacheFolderLocation;
        public static GUIStyle CenteredLabel => Keys.CenteredLabel;
        public static GUIStyle ChannelStripAttenuationBar => Keys.ChannelStripAttenuationBar;
        public static GUIStyle ChannelStripAttenuationMarkerSquare => Keys.ChannelStripAttenuationMarkerSquare;
        public static GUIStyle ChannelStripBg => Keys.ChannelStripBg;
        public static GUIStyle ChannelStripDuckingMarker => Keys.ChannelStripDuckingMarker;
        public static GUIStyle ChannelStripEffectBar => Keys.ChannelStripEffectBar;
        public static GUIStyle ChannelStripSendReturnBar => Keys.ChannelStripSendReturnBar;
        public static GUIStyle ChannelStripVUMeterBg => Keys.ChannelStripVUMeterBg;
        public static GUIStyle CircularToggle => Keys.CircularToggle;
        public static GUIStyle CN_Box => Keys.CN_Box;
        public static GUIStyle CN_CenteredText => Keys.CN_CenteredText;
        public static GUIStyle CN_CountBadge => Keys.CN_CountBadge;
        public static GUIStyle CN_EntryBackEven => Keys.CN_EntryBackEven;
        public static GUIStyle CN_EntryBackOdd => Keys.CN_EntryBackOdd;
        public static GUIStyle CN_EntryError => Keys.CN_EntryError;
        public static GUIStyle CN_EntryErrorIcon => Keys.CN_EntryErrorIcon;
        public static GUIStyle CN_EntryErrorIconSmall => Keys.CN_EntryErrorIconSmall;
        public static GUIStyle CN_EntryErrorSmall => Keys.CN_EntryErrorSmall;
        public static GUIStyle CN_EntryInfo => Keys.CN_EntryInfo;
        public static GUIStyle CN_EntryInfoIcon => Keys.CN_EntryInfoIcon;
        public static GUIStyle CN_EntryInfoIconSmall => Keys.CN_EntryInfoIconSmall;
        public static GUIStyle CN_EntryInfoSmall => Keys.CN_EntryInfoSmall;
        public static GUIStyle CN_EntryWarn => Keys.CN_EntryWarn;
        public static GUIStyle CN_EntryWarnIcon => Keys.CN_EntryWarnIcon;
        public static GUIStyle CN_EntryWarnIconSmall => Keys.CN_EntryWarnIconSmall;
        public static GUIStyle CN_EntryWarnSmall => Keys.CN_EntryWarnSmall;
        public static GUIStyle CN_Message => Keys.CN_Message;
        public static GUIStyle CN_StacktraceBackground => Keys.CN_StacktraceBackground;
        public static GUIStyle CN_StacktraceStyle => Keys.CN_StacktraceStyle;
        public static GUIStyle CN_StatusError => Keys.CN_StatusError;
        public static GUIStyle CN_StatusInfo => Keys.CN_StatusInfo;
        public static GUIStyle CN_StatusWarn => Keys.CN_StatusWarn;
        public static GUIStyle ColorField => Keys.ColorField;
        public static GUIStyle ColorPicker2DThumb => Keys.ColorPicker2DThumb;
        public static GUIStyle ColorPickerBackground => Keys.ColorPickerBackground;
        public static GUIStyle ColorPickerBox => Keys.ColorPickerBox;
        public static GUIStyle ColorPickerCurrentColor => Keys.ColorPickerCurrentColor;
        public static GUIStyle ColorPickerCurrentExposureSwatchBorder => Keys.ColorPickerCurrentExposureSwatchBorder;
        public static GUIStyle ColorPickerExposureSwatch => Keys.ColorPickerExposureSwatch;
        public static GUIStyle ColorPickerHorizThumb => Keys.ColorPickerHorizThumb;
        public static GUIStyle ColorPickerHueRing => Keys.ColorPickerHueRing;
        public static GUIStyle ColorPickerHueRing_HDR => Keys.ColorPickerHueRing_HDR;
        public static GUIStyle ColorPickerHueRingThumb => Keys.ColorPickerHueRingThumb;
        public static GUIStyle ColorPickerOriginalColor => Keys.ColorPickerOriginalColor;
        public static GUIStyle ColorPickerSliderBackground => Keys.ColorPickerSliderBackground;
        public static GUIStyle Command => Keys.Command;
        public static GUIStyle CommandLeft => Keys.CommandLeft;
        public static GUIStyle CommandMid => Keys.CommandMid;
        public static GUIStyle CommandRight => Keys.CommandRight;
        public static GUIStyle ContentToolbar => Keys.ContentToolbar;
        public static GUIStyle ControlHighlight => Keys.ControlHighlight;
        public static GUIStyle ControlLabel => Keys.ControlLabel;
        public static GUIStyle CurveEditorBackground => Keys.CurveEditorBackground;
        public static GUIStyle CurveEditorLabelTickmarks => Keys.CurveEditorLabelTickmarks;
        public static GUIStyle CurveEditorLabelTickmarksOverflow => Keys.CurveEditorLabelTickmarksOverflow;
        public static GUIStyle CurveEditorRightAlignedLabel => Keys.CurveEditorRightAlignedLabel;
        public static GUIStyle DD_Background => Keys.DD_Background;
        public static GUIStyle DD_HeaderStyle => Keys.DD_HeaderStyle;
        public static GUIStyle DD_ItemCheckmark => Keys.DD_ItemCheckmark;
        public static GUIStyle DD_ItemStyle => Keys.DD_ItemStyle;
        public static GUIStyle DD_LargeItemStyle => Keys.DD_LargeItemStyle;
        public static GUIStyle DefaultCenteredLargeText => Keys.DefaultCenteredLargeText;
        public static GUIStyle DefaultCenteredText => Keys.DefaultCenteredText;
        public static GUIStyle DefaultLineSeparator => Keys.DefaultLineSeparator;
        public static GUIStyle dockarea => Keys.dockarea;
        public static GUIStyle dockareaOverlay => Keys.dockareaOverlay;
        public static GUIStyle dockareaStandalone => Keys.dockareaStandalone;
        public static GUIStyle dockHeader => Keys.dockHeader;
        public static GUIStyle DopesheetBackground => Keys.DopesheetBackground;
        public static GUIStyle Dopesheetkeyframe => Keys.Dopesheetkeyframe;
        public static GUIStyle DopesheetRippleLeft => Keys.DopesheetRippleLeft;
        public static GUIStyle DopesheetRippleRight => Keys.DopesheetRippleRight;
        public static GUIStyle DopesheetScaleLeft => Keys.DopesheetScaleLeft;
        public static GUIStyle DopesheetScaleRight => Keys.DopesheetScaleRight;
        public static GUIStyle dragtab => Keys.dragtab;
        public static GUIStyle dragtab_first => Keys.dragtab_first;
        public static GUIStyle dragtab_scroller_next => Keys.dragtab_scroller_next;
        public static GUIStyle dragtab_scroller_prev => Keys.dragtab_scroller_prev;
        public static GUIStyle dragtabdropwindow => Keys.dragtabdropwindow;
        public static GUIStyle DropDown => Keys.DropDown;
        public static GUIStyle DropDownButton => Keys.DropDownButton;
        public static GUIStyle DropzoneStyle => Keys.DropzoneStyle;
        public static GUIStyle EditModeSingleButton => Keys.EditModeSingleButton;
        public static GUIStyle ErrorLabel => Keys.ErrorLabel;
        public static GUIStyle ExposablePopupItem => Keys.ExposablePopupItem;
        public static GUIStyle ExposablePopupMenu => Keys.ExposablePopupMenu;
        public static GUIStyle EyeDropperHorizontalLine => Keys.EyeDropperHorizontalLine;
        public static GUIStyle EyeDropperPickedPixel => Keys.EyeDropperPickedPixel;
        public static GUIStyle EyeDropperVerticalLine => Keys.EyeDropperVerticalLine;
        public static GUIStyle FloatFieldLinkButton => Keys.FloatFieldLinkButton;
        public static GUIStyle flow_background => Keys.flow_background;
        public static GUIStyle flow_node_0 => Keys.flow_node_0;
        public static GUIStyle flow_node_0_on => Keys.flow_node_0_on;
        public static GUIStyle flow_node_1 => Keys.flow_node_1;
        public static GUIStyle flow_node_1_on => Keys.flow_node_1_on;
        public static GUIStyle flow_node_2 => Keys.flow_node_2;
        public static GUIStyle flow_node_2_on => Keys.flow_node_2_on;
        public static GUIStyle flow_node_3 => Keys.flow_node_3;
        public static GUIStyle flow_node_3_on => Keys.flow_node_3_on;
        public static GUIStyle flow_node_4 => Keys.flow_node_4;
        public static GUIStyle flow_node_4_on => Keys.flow_node_4_on;
        public static GUIStyle flow_node_5 => Keys.flow_node_5;
        public static GUIStyle flow_node_5_on => Keys.flow_node_5_on;
        public static GUIStyle flow_node_6 => Keys.flow_node_6;
        public static GUIStyle flow_node_6_on => Keys.flow_node_6_on;
        public static GUIStyle flow_node_base => Keys.flow_node_base;
        public static GUIStyle flow_node_hex_0 => Keys.flow_node_hex_0;
        public static GUIStyle flow_node_hex_0_on => Keys.flow_node_hex_0_on;
        public static GUIStyle flow_node_hex_1 => Keys.flow_node_hex_1;
        public static GUIStyle flow_node_hex_1_on => Keys.flow_node_hex_1_on;
        public static GUIStyle flow_node_hex_2 => Keys.flow_node_hex_2;
        public static GUIStyle flow_node_hex_2_on => Keys.flow_node_hex_2_on;
        public static GUIStyle flow_node_hex_3 => Keys.flow_node_hex_3;
        public static GUIStyle flow_node_hex_3_on => Keys.flow_node_hex_3_on;
        public static GUIStyle flow_node_hex_4 => Keys.flow_node_hex_4;
        public static GUIStyle flow_node_hex_4_on => Keys.flow_node_hex_4_on;
        public static GUIStyle flow_node_hex_5 => Keys.flow_node_hex_5;
        public static GUIStyle flow_node_hex_5_on => Keys.flow_node_hex_5_on;
        public static GUIStyle flow_node_hex_6 => Keys.flow_node_hex_6;
        public static GUIStyle flow_node_hex_6_on => Keys.flow_node_hex_6_on;
        public static GUIStyle flow_node_hex_base => Keys.flow_node_hex_base;
        public static GUIStyle flow_node_titlebar => Keys.flow_node_titlebar;
        public static GUIStyle flow_target_in => Keys.flow_target_in;
        public static GUIStyle flow_triggerPin_in => Keys.flow_triggerPin_in;
        public static GUIStyle flow_triggerPin_out => Keys.flow_triggerPin_out;
        public static GUIStyle flow_varPin_in => Keys.flow_varPin_in;
        public static GUIStyle flow_varPin_out => Keys.flow_varPin_out;
        public static GUIStyle flow_varPin_tooltip => Keys.flow_varPin_tooltip;
        public static GUIStyle Foldout => Keys.Foldout;
        public static GUIStyle FoldoutHeader => Keys.FoldoutHeader;
        public static GUIStyle FoldoutHeaderIcon => Keys.FoldoutHeaderIcon;
        public static GUIStyle FoldOutPreDrop => Keys.FoldOutPreDrop;
        public static GUIStyle Frame => Keys.Frame;
        public static GUIStyle FrameBox => Keys.FrameBox;
        public static GUIStyle GameViewBackground => Keys.GameViewBackground;
        public static GUIStyle Grad_Down_Swatch => Keys.Grad_Down_Swatch;
        public static GUIStyle Grad_Down_Swatch_Overlay => Keys.Grad_Down_Swatch_Overlay;
        public static GUIStyle Grad_Up_Swatch => Keys.Grad_Up_Swatch;
        public static GUIStyle Grad_Up_Swatch_Overlay => Keys.Grad_Up_Swatch_Overlay;
        public static GUIStyle grey_border => Keys.grey_border;
        public static GUIStyle GridList => Keys.GridList;
        public static GUIStyle GridListText => Keys.GridListText;
        public static GUIStyle GroupBox => Keys.GroupBox;
        public static GUIStyle GUIEditor_BreadcrumbLeft => Keys.GUIEditor_BreadcrumbLeft;
        public static GUIStyle GUIEditor_BreadcrumbLeftBackground => Keys.GUIEditor_BreadcrumbLeftBackground;
        public static GUIStyle GUIEditor_BreadcrumbMid => Keys.GUIEditor_BreadcrumbMid;
        public static GUIStyle GUIEditor_BreadcrumbMidBackground => Keys.GUIEditor_BreadcrumbMidBackground;
        public static GUIStyle GV_Gizmo_DropDown => Keys.GV_Gizmo_DropDown;
        public static GUIStyle HeaderButton => Keys.HeaderButton;
        public static GUIStyle HeaderLabel => Keys.HeaderLabel;
        public static GUIStyle HelpBox => Keys.HelpBox;
        public static GUIStyle Hi_Label => Keys.Hi_Label;
        public static GUIStyle HorizontalMinMaxScrollbarThumb => Keys.HorizontalMinMaxScrollbarThumb;
        public static GUIStyle HorizontalSliderThumbExtent => Keys.HorizontalSliderThumbExtent;
        public static GUIStyle hostview => Keys.hostview;
        public static GUIStyle IconButton => Keys.IconButton;
        public static GUIStyle IN_BigTitle => Keys.IN_BigTitle;
        public static GUIStyle IN_BigTitle_Inner => Keys.IN_BigTitle_Inner;
        public static GUIStyle IN_BigTitle_Post => Keys.IN_BigTitle_Post;
        public static GUIStyle IN_CenteredLabel => Keys.IN_CenteredLabel;
        public static GUIStyle IN_DropDown => Keys.IN_DropDown;
        public static GUIStyle IN_EditColliderButton => Keys.IN_EditColliderButton;
        public static GUIStyle IN_Foldout => Keys.IN_Foldout;
        public static GUIStyle IN_Footer => Keys.IN_Footer;
        public static GUIStyle IN_Label => Keys.IN_Label;
        public static GUIStyle IN_LockButton => Keys.IN_LockButton;
        public static GUIStyle IN_MinMaxStateDropDown => Keys.IN_MinMaxStateDropDown;
        public static GUIStyle IN_ObjectField => Keys.IN_ObjectField;
        public static GUIStyle IN_TextField => Keys.IN_TextField;
        public static GUIStyle IN_ThumbnailSelection => Keys.IN_ThumbnailSelection;
        public static GUIStyle IN_ThumbnailShadow => Keys.IN_ThumbnailShadow;
        public static GUIStyle IN_Title => Keys.IN_Title;
        public static GUIStyle IN_Title_Flat => Keys.IN_Title_Flat;
        public static GUIStyle IN_TitleText => Keys.IN_TitleText;
        public static GUIStyle IN_TypeSelection => Keys.IN_TypeSelection;
        public static GUIStyle InnerShadowBg => Keys.InnerShadowBg;
        public static GUIStyle InsertionMarker => Keys.InsertionMarker;
        public static GUIStyle InvisibleButton => Keys.InvisibleButton;
        public static GUIStyle LargeBoldLabel => Keys.LargeBoldLabel;
        public static GUIStyle LargeButton => Keys.LargeButton;
        public static GUIStyle LargeButtonLeft => Keys.LargeButtonLeft;
        public static GUIStyle LargeButtonMid => Keys.LargeButtonMid;
        public static GUIStyle LargeButtonRight => Keys.LargeButtonRight;
        public static GUIStyle LargeLabel => Keys.LargeLabel;
        public static GUIStyle LightmapEditorSelectedHighlight => Keys.LightmapEditorSelectedHighlight;
        public static GUIStyle LinkLabel => Keys.LinkLabel;
        public static GUIStyle LODBlackBox => Keys.LODBlackBox;
        public static GUIStyle LODCameraLine => Keys.LODCameraLine;
        public static GUIStyle LODLevelNotifyText => Keys.LODLevelNotifyText;
        public static GUIStyle LODRendererAddButton => Keys.LODRendererAddButton;
        public static GUIStyle LODRendererButton => Keys.LODRendererButton;
        public static GUIStyle LODRendererRemove => Keys.LODRendererRemove;
        public static GUIStyle LODRenderersText => Keys.LODRenderersText;
        public static GUIStyle LODSceneText => Keys.LODSceneText;
        public static GUIStyle LODSliderBG => Keys.LODSliderBG;
        public static GUIStyle LODSliderRange => Keys.LODSliderRange;
        public static GUIStyle LODSliderRangeSelected => Keys.LODSliderRangeSelected;
        public static GUIStyle LODSliderText => Keys.LODSliderText;
        public static GUIStyle LODSliderTextSelected => Keys.LODSliderTextSelected;
        public static GUIStyle MeBlendBackground => Keys.MeBlendBackground;
        public static GUIStyle MeBlendPosition => Keys.MeBlendPosition;
        public static GUIStyle MeBlendTriangleLeft => Keys.MeBlendTriangleLeft;
        public static GUIStyle MeBlendTriangleRight => Keys.MeBlendTriangleRight;
        public static GUIStyle MeLivePlayBackground => Keys.MeLivePlayBackground;
        public static GUIStyle MeLivePlayBar => Keys.MeLivePlayBar;
        public static GUIStyle MenuItem => Keys.MenuItem;
        public static GUIStyle MenuItemMixed => Keys.MenuItemMixed;
        public static GUIStyle MenuToggleItem => Keys.MenuToggleItem;
        public static GUIStyle MeTimeBlockLeft => Keys.MeTimeBlockLeft;
        public static GUIStyle MeTimeBlockRight => Keys.MeTimeBlockRight;
        public static GUIStyle MeTimeLabel => Keys.MeTimeLabel;
        public static GUIStyle MeTransitionBack => Keys.MeTransitionBack;
        public static GUIStyle MeTransitionBlock => Keys.MeTransitionBlock;
        public static GUIStyle MeTransitionHandleLeft => Keys.MeTransitionHandleLeft;
        public static GUIStyle MeTransitionHandleLeftPrev => Keys.MeTransitionHandleLeftPrev;
        public static GUIStyle MeTransitionHandleRight => Keys.MeTransitionHandleRight;
        public static GUIStyle MeTransitionHead => Keys.MeTransitionHead;
        public static GUIStyle MeTransitionSelect => Keys.MeTransitionSelect;
        public static GUIStyle MeTransitionSelectHead => Keys.MeTransitionSelectHead;
        public static GUIStyle MeTransOff2On => Keys.MeTransOff2On;
        public static GUIStyle MeTransOffLeft => Keys.MeTransOffLeft;
        public static GUIStyle MeTransOffRight => Keys.MeTransOffRight;
        public static GUIStyle MeTransOn2Off => Keys.MeTransOn2Off;
        public static GUIStyle MeTransOnLeft => Keys.MeTransOnLeft;
        public static GUIStyle MeTransOnRight => Keys.MeTransOnRight;
        public static GUIStyle MeTransPlayhead => Keys.MeTransPlayhead;
        public static GUIStyle MiniBoldLabel => Keys.MiniBoldLabel;
        public static GUIStyle minibutton => Keys.minibutton;
        public static GUIStyle minibuttonleft => Keys.minibuttonleft;
        public static GUIStyle minibuttonmid => Keys.minibuttonmid;
        public static GUIStyle minibuttonright => Keys.minibuttonright;
        public static GUIStyle MiniLabel => Keys.MiniLabel;
        public static GUIStyle MiniMinMaxSliderHorizontal => Keys.MiniMinMaxSliderHorizontal;
        public static GUIStyle MiniMinMaxSliderVertical => Keys.MiniMinMaxSliderVertical;
        public static GUIStyle MiniPopup => Keys.MiniPopup;
        public static GUIStyle MiniPullDown => Keys.MiniPullDown;
        public static GUIStyle MiniSliderHorizontal => Keys.MiniSliderHorizontal;
        public static GUIStyle MiniSliderVertical => Keys.MiniSliderVertical;
        public static GUIStyle MiniTextField => Keys.MiniTextField;
        public static GUIStyle MiniToolbarButton => Keys.MiniToolbarButton;
        public static GUIStyle MiniToolbarButtonLeft => Keys.MiniToolbarButtonLeft;
        public static GUIStyle MinMaxHorizontalSliderThumb => Keys.MinMaxHorizontalSliderThumb;
        public static GUIStyle MultiColumnArrow => Keys.MultiColumnArrow;
        public static GUIStyle MultiColumnHeader => Keys.MultiColumnHeader;
        public static GUIStyle MultiColumnHeaderCenter => Keys.MultiColumnHeaderCenter;
        public static GUIStyle MultiColumnHeaderRight => Keys.MultiColumnHeaderRight;
        public static GUIStyle MultiColumnTopBar => Keys.MultiColumnTopBar;
        public static GUIStyle MuteToggle => Keys.MuteToggle;
        public static GUIStyle NotificationBackground => Keys.NotificationBackground;
        public static GUIStyle NotificationText => Keys.NotificationText;
        public static GUIStyle ObjectField => Keys.ObjectField;
        public static GUIStyle ObjectFieldButton => Keys.ObjectFieldButton;
        public static GUIStyle ObjectFieldMiniThumb => Keys.ObjectFieldMiniThumb;
        public static GUIStyle ObjectFieldThumb => Keys.ObjectFieldThumb;
        public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay => Keys.ObjectFieldThumbLightmapPreviewOverlay;
        public static GUIStyle ObjectFieldThumbOverlay => Keys.ObjectFieldThumbOverlay;
        public static GUIStyle ObjectFieldThumbOverlay2 => Keys.ObjectFieldThumbOverlay2;
        public static GUIStyle ObjectPickerBackground => Keys.ObjectPickerBackground;
        public static GUIStyle ObjectPickerLargeStatus => Keys.ObjectPickerLargeStatus;
        public static GUIStyle ObjectPickerPreviewBackground => Keys.ObjectPickerPreviewBackground;
        public static GUIStyle ObjectPickerResultsEven => Keys.ObjectPickerResultsEven;
        public static GUIStyle ObjectPickerResultsGrid => Keys.ObjectPickerResultsGrid;
        public static GUIStyle ObjectPickerResultsOdd => Keys.ObjectPickerResultsOdd;
        public static GUIStyle ObjectPickerSmallStatus => Keys.ObjectPickerSmallStatus;
        public static GUIStyle ObjectPickerTab => Keys.ObjectPickerTab;
        public static GUIStyle ObjectPickerToolbar => Keys.ObjectPickerToolbar;
        public static GUIStyle OffsetDropDown => Keys.OffsetDropDown;
        public static GUIStyle OL_box => Keys.OL_box;
        public static GUIStyle OL_box_flat => Keys.OL_box_flat;
        public static GUIStyle OL_box_NoExpand => Keys.OL_box_NoExpand;
        public static GUIStyle OL_EntryBackEven => Keys.OL_EntryBackEven;
        public static GUIStyle OL_EntryBackOdd => Keys.OL_EntryBackOdd;
        public static GUIStyle OL_Label => Keys.OL_Label;
        public static GUIStyle OL_MiniPing => Keys.OL_MiniPing;
        public static GUIStyle OL_MiniRenameField => Keys.OL_MiniRenameField;
        public static GUIStyle OL_Minus => Keys.OL_Minus;
        public static GUIStyle OL_Ping => Keys.OL_Ping;
        public static GUIStyle OL_Plus => Keys.OL_Plus;
        public static GUIStyle OL_ResultFocusMarker => Keys.OL_ResultFocusMarker;
        public static GUIStyle OL_ResultLabel => Keys.OL_ResultLabel;
        public static GUIStyle OL_RightLabel => Keys.OL_RightLabel;
        public static GUIStyle OL_SelectedRow => Keys.OL_SelectedRow;
        public static GUIStyle OL_Title => Keys.OL_Title;
        public static GUIStyle OL_Title_TextRight => Keys.OL_Title_TextRight;
        public static GUIStyle OL_Toggle => Keys.OL_Toggle;
        public static GUIStyle OL_ToggleMixed => Keys.OL_ToggleMixed;
        public static GUIStyle OL_ToggleWhite => Keys.OL_ToggleWhite;
        public static GUIStyle OT_BottomBar => Keys.OT_BottomBar;
        public static GUIStyle OT_TopBar => Keys.OT_TopBar;
        public static GUIStyle OverrideMargin => Keys.OverrideMargin;
        public static GUIStyle PaneOptions => Keys.PaneOptions;
        public static GUIStyle PlayerSettingsLevel => Keys.PlayerSettingsLevel;
        public static GUIStyle PlayerSettingsPlatform => Keys.PlayerSettingsPlatform;
        public static GUIStyle Popup => Keys.Popup;
        public static GUIStyle PopupCurveDropdown => Keys.PopupCurveDropdown;
        public static GUIStyle PopupCurveEditorBackground => Keys.PopupCurveEditorBackground;
        public static GUIStyle PopupCurveEditorSwatch => Keys.PopupCurveEditorSwatch;
        public static GUIStyle PopupCurveSwatchBackground => Keys.PopupCurveSwatchBackground;
        public static GUIStyle PR_BrokenPrefabLabel => Keys.PR_BrokenPrefabLabel;
        public static GUIStyle PR_DisabledBrokenPrefabLabel => Keys.PR_DisabledBrokenPrefabLabel;
        public static GUIStyle PR_DisabledLabel => Keys.PR_DisabledLabel;
        public static GUIStyle PR_DisabledPrefabLabel => Keys.PR_DisabledPrefabLabel;
        public static GUIStyle PR_Insertion => Keys.PR_Insertion;
        public static GUIStyle PR_Label => Keys.PR_Label;
        public static GUIStyle PR_Ping => Keys.PR_Ping;
        public static GUIStyle PR_PrefabLabel => Keys.PR_PrefabLabel;
        public static GUIStyle PR_TextField => Keys.PR_TextField;
        public static GUIStyle PreBackground => Keys.PreBackground;
        public static GUIStyle PreBackgroundSolid => Keys.PreBackgroundSolid;
        public static GUIStyle PreButton => Keys.PreButton;
        public static GUIStyle PreButtonBlue => Keys.PreButtonBlue;
        public static GUIStyle PreButtonGreen => Keys.PreButtonGreen;
        public static GUIStyle PreButtonRed => Keys.PreButtonRed;
        public static GUIStyle PreDropDown => Keys.PreDropDown;
        public static GUIStyle PreferencesKeysElement => Keys.PreferencesKeysElement;
        public static GUIStyle PreferencesSection => Keys.PreferencesSection;
        public static GUIStyle PreferencesSectionBox => Keys.PreferencesSectionBox;
        public static GUIStyle PrefixLabel => Keys.PrefixLabel;
        public static GUIStyle PreHorizontalScrollbar => Keys.PreHorizontalScrollbar;
        public static GUIStyle PreHorizontalScrollbarThumb => Keys.PreHorizontalScrollbarThumb;
        public static GUIStyle PreLabel => Keys.PreLabel;
        public static GUIStyle PreLabelUpper => Keys.PreLabelUpper;
        public static GUIStyle PreMiniLabel => Keys.PreMiniLabel;
        public static GUIStyle PreOverlayLabel => Keys.PreOverlayLabel;
        public static GUIStyle PreSlider => Keys.PreSlider;
        public static GUIStyle PreSliderThumb => Keys.PreSliderThumb;
        public static GUIStyle PreToolbar => Keys.PreToolbar;
        public static GUIStyle PreToolbar2 => Keys.PreToolbar2;
        public static GUIStyle PreVerticalScrollbar => Keys.PreVerticalScrollbar;
        public static GUIStyle PreVerticalScrollbarThumb => Keys.PreVerticalScrollbarThumb;
        public static GUIStyle PreviewPackageInUse => Keys.PreviewPackageInUse;
        public static GUIStyle ProfilerBadge => Keys.ProfilerBadge;
        public static GUIStyle ProfilerDetailViewBackground => Keys.ProfilerDetailViewBackground;
        public static GUIStyle ProfilerGraphBackground => Keys.ProfilerGraphBackground;
        public static GUIStyle ProfilerHeaderLabel => Keys.ProfilerHeaderLabel;
        public static GUIStyle ProfilerLeftPane => Keys.ProfilerLeftPane;
        public static GUIStyle ProfilerNoDataAvailable => Keys.ProfilerNoDataAvailable;
        public static GUIStyle ProfilerNotSupportedWarningLabel => Keys.ProfilerNotSupportedWarningLabel;
        public static GUIStyle ProfilerPaneSubLabel => Keys.ProfilerPaneSubLabel;
        public static GUIStyle ProfilerRightPane => Keys.ProfilerRightPane;
        public static GUIStyle ProfilerScrollviewBackground => Keys.ProfilerScrollviewBackground;
        public static GUIStyle ProfilerSelectedLabel => Keys.ProfilerSelectedLabel;
        public static GUIStyle ProfilerTimelineBar => Keys.ProfilerTimelineBar;
        public static GUIStyle ProfilerTimelineDigDownArrow => Keys.ProfilerTimelineDigDownArrow;
        public static GUIStyle ProfilerTimelineFoldout => Keys.ProfilerTimelineFoldout;
        public static GUIStyle ProfilerTimelineLeftPane => Keys.ProfilerTimelineLeftPane;
        public static GUIStyle ProfilerTimelineRollUpArrow => Keys.ProfilerTimelineRollUpArrow;
        public static GUIStyle ProgressBarBack => Keys.ProgressBarBack;
        public static GUIStyle ProgressBarBar => Keys.ProgressBarBar;
        public static GUIStyle ProgressBarText => Keys.ProgressBarText;
        public static GUIStyle ProjectBrowserBottomBarBg => Keys.ProjectBrowserBottomBarBg;
        public static GUIStyle ProjectBrowserGridLabel => Keys.ProjectBrowserGridLabel;
        public static GUIStyle ProjectBrowserHeaderBgMiddle => Keys.ProjectBrowserHeaderBgMiddle;
        public static GUIStyle ProjectBrowserHeaderBgTop => Keys.ProjectBrowserHeaderBgTop;
        public static GUIStyle ProjectBrowserIconAreaBg => Keys.ProjectBrowserIconAreaBg;
        public static GUIStyle ProjectBrowserIconDropShadow => Keys.ProjectBrowserIconDropShadow;
        public static GUIStyle ProjectBrowserPreviewBg => Keys.ProjectBrowserPreviewBg;
        public static GUIStyle ProjectBrowserSubAssetBg => Keys.ProjectBrowserSubAssetBg;
        public static GUIStyle ProjectBrowserSubAssetBgCloseEnded => Keys.ProjectBrowserSubAssetBgCloseEnded;
        public static GUIStyle ProjectBrowserSubAssetBgDivider => Keys.ProjectBrowserSubAssetBgDivider;
        public static GUIStyle ProjectBrowserSubAssetBgMiddle => Keys.ProjectBrowserSubAssetBgMiddle;
        public static GUIStyle ProjectBrowserSubAssetBgOpenEnded => Keys.ProjectBrowserSubAssetBgOpenEnded;
        public static GUIStyle ProjectBrowserSubAssetExpandBtn => Keys.ProjectBrowserSubAssetExpandBtn;
        public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium => Keys.ProjectBrowserSubAssetExpandBtnMedium;
        public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall => Keys.ProjectBrowserSubAssetExpandBtnSmall;
        public static GUIStyle ProjectBrowserTextureIconDropShadow => Keys.ProjectBrowserTextureIconDropShadow;
        public static GUIStyle ProjectBrowserTopBarBg => Keys.ProjectBrowserTopBarBg;
        public static GUIStyle QualitySettingsDefault => Keys.QualitySettingsDefault;
        public static GUIStyle quick_search_tab => Keys.quick_search_tab;
        public static GUIStyle Radio => Keys.Radio;
        public static GUIStyle RectangleToolHBar => Keys.RectangleToolHBar;
        public static GUIStyle RectangleToolHBarLeft => Keys.RectangleToolHBarLeft;
        public static GUIStyle RectangleToolHBarRight => Keys.RectangleToolHBarRight;
        public static GUIStyle RectangleToolHighlight => Keys.RectangleToolHighlight;
        public static GUIStyle RectangleToolRippleLeft => Keys.RectangleToolRippleLeft;
        public static GUIStyle RectangleToolRippleRight => Keys.RectangleToolRippleRight;
        public static GUIStyle RectangleToolScaleBottom => Keys.RectangleToolScaleBottom;
        public static GUIStyle RectangleToolScaleLeft => Keys.RectangleToolScaleLeft;
        public static GUIStyle RectangleToolScaleRight => Keys.RectangleToolScaleRight;
        public static GUIStyle RectangleToolScaleTop => Keys.RectangleToolScaleTop;
        public static GUIStyle RectangleToolSelection => Keys.RectangleToolSelection;
        public static GUIStyle RectangleToolVBar => Keys.RectangleToolVBar;
        public static GUIStyle RectangleToolVBarBottom => Keys.RectangleToolVBarBottom;
        public static GUIStyle RectangleToolVBarTop => Keys.RectangleToolVBarTop;
        public static GUIStyle RegionBg => Keys.RegionBg;
        public static GUIStyle ReorderableList => Keys.ReorderableList;
        public static GUIStyle ReorderableListRightAligned => Keys.ReorderableListRightAligned;
        public static GUIStyle RightAlignedLabel => Keys.RightAlignedLabel;
        public static GUIStyle RightLabel => Keys.RightLabel;
        public static GUIStyle RL_Background => Keys.RL_Background;
        public static GUIStyle RL_DragHandle => Keys.RL_DragHandle;
        public static GUIStyle RL_Element => Keys.RL_Element;
        public static GUIStyle RL_Empty_Header => Keys.RL_Empty_Header;
        public static GUIStyle RL_Footer => Keys.RL_Footer;
        public static GUIStyle RL_FooterButton => Keys.RL_FooterButton;
        public static GUIStyle RL_Header => Keys.RL_Header;
        public static GUIStyle SC_ViewAxisLabel => Keys.SC_ViewAxisLabel;
        public static GUIStyle SC_ViewLabel => Keys.SC_ViewLabel;
        public static GUIStyle SC_ViewLabelCentered => Keys.SC_ViewLabelCentered;
        public static GUIStyle SC_ViewLabelLeftAligned => Keys.SC_ViewLabelLeftAligned;
        public static GUIStyle SceneTopBarBg => Keys.SceneTopBarBg;
        public static GUIStyle SceneViewOverlayTransparentBackground => Keys.SceneViewOverlayTransparentBackground;
        public static GUIStyle SceneVisibility => Keys.SceneVisibility;
        public static GUIStyle ScriptText => Keys.ScriptText;
        public static GUIStyle ScrollViewAlt => Keys.ScrollViewAlt;
        public static GUIStyle SearchCancelButton => Keys.SearchCancelButton;
        public static GUIStyle SearchCancelButtonEmpty => Keys.SearchCancelButtonEmpty;
        public static GUIStyle SearchModeFilter => Keys.SearchModeFilter;
        public static GUIStyle SearchTextField => Keys.SearchTextField;
        public static GUIStyle SelectionRect => Keys.SelectionRect;
        public static GUIStyle SettingsHeader => Keys.SettingsHeader;
        public static GUIStyle SettingsIconButton => Keys.SettingsIconButton;
        public static GUIStyle SettingsListItem => Keys.SettingsListItem;
        public static GUIStyle SettingsTreeItem => Keys.SettingsTreeItem;
        public static GUIStyle ShurikenCheckMark => Keys.ShurikenCheckMark;
        public static GUIStyle ShurikenCheckMarkMixed => Keys.ShurikenCheckMarkMixed;
        public static GUIStyle ShurikenDropdown => Keys.ShurikenDropdown;
        public static GUIStyle ShurikenEditableLabel => Keys.ShurikenEditableLabel;
        public static GUIStyle ShurikenEffectBg => Keys.ShurikenEffectBg;
        public static GUIStyle ShurikenEmitterTitle => Keys.ShurikenEmitterTitle;
        public static GUIStyle ShurikenLabel => Keys.ShurikenLabel;
        public static GUIStyle ShurikenMinus => Keys.ShurikenMinus;
        public static GUIStyle ShurikenModuleBg => Keys.ShurikenModuleBg;
        public static GUIStyle ShurikenModuleTitle => Keys.ShurikenModuleTitle;
        public static GUIStyle ShurikenObjectField => Keys.ShurikenObjectField;
        public static GUIStyle ShurikenPlus => Keys.ShurikenPlus;
        public static GUIStyle ShurikenPopup => Keys.ShurikenPopup;
        public static GUIStyle ShurikenToggle => Keys.ShurikenToggle;
        public static GUIStyle ShurikenToggleMixed => Keys.ShurikenToggleMixed;
        public static GUIStyle ShurikenValue => Keys.ShurikenValue;
        public static GUIStyle SliderMixed => Keys.SliderMixed;
        public static GUIStyle SoloToggle => Keys.SoloToggle;
        public static GUIStyle StaticDropdown => Keys.StaticDropdown;
        public static GUIStyle StatusBarIcon => Keys.StatusBarIcon;
        public static GUIStyle sv_iconselector_back => Keys.sv_iconselector_back;
        public static GUIStyle sv_iconselector_button => Keys.sv_iconselector_button;
        public static GUIStyle sv_iconselector_labelselection => Keys.sv_iconselector_labelselection;
        public static GUIStyle sv_iconselector_selection => Keys.sv_iconselector_selection;
        public static GUIStyle sv_iconselector_sep => Keys.sv_iconselector_sep;
        public static GUIStyle sv_label_0 => Keys.sv_label_0;
        public static GUIStyle sv_label_1 => Keys.sv_label_1;
        public static GUIStyle sv_label_2 => Keys.sv_label_2;
        public static GUIStyle sv_label_3 => Keys.sv_label_3;
        public static GUIStyle sv_label_4 => Keys.sv_label_4;
        public static GUIStyle sv_label_5 => Keys.sv_label_5;
        public static GUIStyle sv_label_6 => Keys.sv_label_6;
        public static GUIStyle sv_label_7 => Keys.sv_label_7;
        public static GUIStyle Tab_first => Keys.Tab_first;
        public static GUIStyle Tab_last => Keys.Tab_last;
        public static GUIStyle Tab_middle => Keys.Tab_middle;
        public static GUIStyle Tab_onlyOne => Keys.Tab_onlyOne;
        public static GUIStyle TabWindowBackground => Keys.TabWindowBackground;
        public static GUIStyle Tag_MenuItem => Keys.Tag_MenuItem;
        public static GUIStyle TE_BoxBackground => Keys.TE_BoxBackground;
        public static GUIStyle TE_DefaultTime => Keys.TE_DefaultTime;
        public static GUIStyle TE_DropField => Keys.TE_DropField;
        public static GUIStyle TE_ElementBackground => Keys.TE_ElementBackground;
        public static GUIStyle TE_NodeBackground => Keys.TE_NodeBackground;
        public static GUIStyle TE_NodeBox => Keys.TE_NodeBox;
        public static GUIStyle TE_NodeBoxSelected => Keys.TE_NodeBoxSelected;
        public static GUIStyle TE_NodeLabelBot => Keys.TE_NodeLabelBot;
        public static GUIStyle TE_NodeLabelTop => Keys.TE_NodeLabelTop;
        public static GUIStyle TE_PinLabel => Keys.TE_PinLabel;
        public static GUIStyle TE_Toolbar => Keys.TE_Toolbar;
        public static GUIStyle TE_toolbarbutton => Keys.TE_toolbarbutton;
        public static GUIStyle TE_ToolbarDropDown => Keys.TE_ToolbarDropDown;
        public static GUIStyle TextFieldDropDown => Keys.TextFieldDropDown;
        public static GUIStyle TextFieldDropDownText => Keys.TextFieldDropDownText;
        public static GUIStyle TimeAreaToolbar => Keys.TimeAreaToolbar;
        public static GUIStyle TimeRulerBackground => Keys.TimeRulerBackground;
        public static GUIStyle TimeScrubber => Keys.TimeScrubber;
        public static GUIStyle TimeScrubberButton => Keys.TimeScrubberButton;
        public static GUIStyle Titlebar_Foldout => Keys.Titlebar_Foldout;
        public static GUIStyle TL_InPoint => Keys.TL_InPoint;
        public static GUIStyle TL_OutPoint => Keys.TL_OutPoint;
        public static GUIStyle TL_Playhead => Keys.TL_Playhead;
        public static GUIStyle ToggleMixed => Keys.ToggleMixed;
        public static GUIStyle Toolbar => Keys.Toolbar;
        public static GUIStyle ToolbarBoldLabel => Keys.ToolbarBoldLabel;
        public static GUIStyle ToolbarBottom => Keys.ToolbarBottom;
        public static GUIStyle toolbarbutton => Keys.toolbarbutton;
        public static GUIStyle ToolbarButtonFlat => Keys.ToolbarButtonFlat;
        public static GUIStyle toolbarbuttonLeft => Keys.toolbarbuttonLeft;
        public static GUIStyle toolbarbuttonRight => Keys.toolbarbuttonRight;
        public static GUIStyle ToolbarCreateAddNewDropDown => Keys.ToolbarCreateAddNewDropDown;
        public static GUIStyle ToolbarDropDown => Keys.ToolbarDropDown;
        public static GUIStyle ToolbarDropDownLeft => Keys.ToolbarDropDownLeft;
        public static GUIStyle ToolbarDropDownRight => Keys.ToolbarDropDownRight;
        public static GUIStyle ToolbarDropDownToggle => Keys.ToolbarDropDownToggle;
        public static GUIStyle ToolbarDropDownToggleRight => Keys.ToolbarDropDownToggleRight;
        public static GUIStyle ToolbarLabel => Keys.ToolbarLabel;
        public static GUIStyle ToolbarPopup => Keys.ToolbarPopup;
        public static GUIStyle ToolbarPopupLeft => Keys.ToolbarPopupLeft;
        public static GUIStyle ToolbarPopupRight => Keys.ToolbarPopupRight;
        public static GUIStyle ToolbarSeachCancelButton => Keys.ToolbarSeachCancelButton;
        public static GUIStyle ToolbarSeachCancelButtonEmpty => Keys.ToolbarSeachCancelButtonEmpty;
        public static GUIStyle ToolbarSeachTextField => Keys.ToolbarSeachTextField;
        public static GUIStyle ToolbarSeachTextFieldPopup => Keys.ToolbarSeachTextFieldPopup;
        public static GUIStyle ToolbarSearchCancelButtonWithJump => Keys.ToolbarSearchCancelButtonWithJump;
        public static GUIStyle ToolbarSearchCancelButtonWithJumpEmpty => Keys.ToolbarSearchCancelButtonWithJumpEmpty;
        public static GUIStyle ToolbarSearchField => Keys.ToolbarSearchField;
        public static GUIStyle ToolbarSearchTextFieldJumpButton => Keys.ToolbarSearchTextFieldJumpButton;
        public static GUIStyle ToolbarSearchTextFieldWithJump => Keys.ToolbarSearchTextFieldWithJump;
        public static GUIStyle ToolbarSearchTextFieldWithJumpPopup => Keys.ToolbarSearchTextFieldWithJumpPopup;

        public static GUIStyle ToolbarSearchTextFieldWithJumpPopupSynced =>
            Keys.ToolbarSearchTextFieldWithJumpPopupSynced;

        public static GUIStyle ToolbarSearchTextFieldWithJumpSynced => Keys.ToolbarSearchTextFieldWithJumpSynced;
        public static GUIStyle ToolbarSlider => Keys.ToolbarSlider;
        public static GUIStyle ToolbarSliderTextField => Keys.ToolbarSliderTextField;
        public static GUIStyle ToolbarTextField => Keys.ToolbarTextField;
        public static GUIStyle Tooltip => Keys.Tooltip;
        public static GUIStyle TV_Insertion => Keys.TV_Insertion;
        public static GUIStyle TV_Line => Keys.TV_Line;
        public static GUIStyle TV_LineBold => Keys.TV_LineBold;
        public static GUIStyle TV_Ping => Keys.TV_Ping;
        public static GUIStyle TV_Selection => Keys.TV_Selection;
        public static GUIStyle U2D_createRect => Keys.U2D_createRect;
        public static GUIStyle U2D_dragDot => Keys.U2D_dragDot;
        public static GUIStyle U2D_dragDotActive => Keys.U2D_dragDotActive;
        public static GUIStyle U2D_dragDotDimmed => Keys.U2D_dragDotDimmed;
        public static GUIStyle U2D_pivotDot => Keys.U2D_pivotDot;
        public static GUIStyle U2D_pivotDotActive => Keys.U2D_pivotDotActive;
        public static GUIStyle VerticalMinMaxScrollbarThumb => Keys.VerticalMinMaxScrollbarThumb;
        public static GUIStyle VerticalSliderThumbExtent => Keys.VerticalSliderThumbExtent;
        public static GUIStyle VideoClipImporterLabel => Keys.VideoClipImporterLabel;
        public static GUIStyle WarningOverlay => Keys.WarningOverlay;
        public static GUIStyle WhiteBackground => Keys.WhiteBackground;
        public static GUIStyle WhiteBoldLabel => Keys.WhiteBoldLabel;
        public static GUIStyle WhiteLabel => Keys.WhiteLabel;
        public static GUIStyle WhiteLargeCenterLabel => Keys.WhiteLargeCenterLabel;
        public static GUIStyle WhiteLargeLabel => Keys.WhiteLargeLabel;
        public static GUIStyle WhiteMiniLabel => Keys.WhiteMiniLabel;
        public static GUIStyle WinBtn => Keys.WinBtn;
        public static GUIStyle WinBtnClose => Keys.WinBtnClose;
        public static GUIStyle WinBtnCloseMac => Keys.WinBtnCloseMac;
        public static GUIStyle WinBtnInactiveMac => Keys.WinBtnInactiveMac;
        public static GUIStyle WinBtnMax => Keys.WinBtnMax;
        public static GUIStyle WinBtnMaxMac => Keys.WinBtnMaxMac;
        public static GUIStyle WinBtnMinMac => Keys.WinBtnMinMac;
        public static GUIStyle WinBtnRestore => Keys.WinBtnRestore;
        public static GUIStyle WinBtnRestoreMac => Keys.WinBtnRestoreMac;
        public static GUIStyle WindowBottomResize => Keys.WindowBottomResize;
        public static GUIStyle Wizard_Box => Keys.Wizard_Box;
        public static GUIStyle Wizard_Error => Keys.Wizard_Error;
        public static GUIStyle WordWrapLabel => Keys.WordWrapLabel;
        public static GUIStyle wordwrapminibutton => Keys.wordwrapminibutton;
        public static GUIStyle WordWrappedLabel => Keys.WordWrappedLabel;
        public static GUIStyle WordWrappedMiniLabel => Keys.WordWrappedMiniLabel;

        public static class Keys {
            public const string box = "box";
            public const string button = "button";
            public const string toggle = "toggle";
            public const string label = "label";
            public const string window = "window";
            public const string textfield = "textfield";
            public const string textarea = "textarea";
            public const string horizontalslider = "horizontalslider";
            public const string horizontalsliderthumb = "horizontalsliderthumb";
            public const string verticalslider = "verticalslider";
            public const string verticalsliderthumb = "verticalsliderthumb";
            public const string horizontalscrollbar = "horizontalscrollbar";
            public const string horizontalscrollbarthumb = "horizontalscrollbarthumb";
            public const string horizontalscrollbarleftbutton = "horizontalscrollbarleftbutton";
            public const string horizontalscrollbarrightbutton = "horizontalscrollbarrightbutton";
            public const string verticalscrollbar = "verticalscrollbar";
            public const string verticalscrollbarthumb = "verticalscrollbarthumb";
            public const string verticalscrollbarupbutton = "verticalscrollbarupbutton";
            public const string verticalscrollbardownbutton = "verticalscrollbardownbutton";
            public const string scrollview = "scrollview";
            public const string AboutWIndowLicenseLabel = "AboutWIndowLicenseLabel";
            public const string AC_BoldHeader = "AC BoldHeader";
            public const string AC_Button = "AC Button";
            public const string AC_ComponentButton = "AC ComponentButton";
            public const string AC_GroupButton = "AC GroupButton";
            public const string AC_LeftArrow = "AC LeftArrow";
            public const string AC_PreviewHeader = "AC PreviewHeader";
            public const string AC_PreviewText = "AC PreviewText";
            public const string AC_RightArrow = "AC RightArrow";
            public const string AM_ChannelStripHeaderStyle = "AM ChannelStripHeaderStyle";
            public const string AM_EffectName = "AM EffectName";
            public const string AM_HeaderStyle = "AM HeaderStyle";
            public const string AM_MixerHeader = "AM MixerHeader";
            public const string AM_MixerHeader2 = "AM MixerHeader2";
            public const string AM_ToolbarLabel = "AM ToolbarLabel";
            public const string AM_ToolbarObjectField = "AM ToolbarObjectField";
            public const string AM_TotalVuLabel = "AM TotalVuLabel";
            public const string AM_VuValue = "AM VuValue";
            public const string AnimationEventBackground = "AnimationEventBackground";
            public const string AnimationEventTooltip = "AnimationEventTooltip";
            public const string AnimationEventTooltipArrow = "AnimationEventTooltipArrow";
            public const string AnimationKeyframeBackground = "AnimationKeyframeBackground";
            public const string AnimationPlayHead = "AnimationPlayHead";
            public const string AnimationRowEven = "AnimationRowEven";
            public const string AnimationRowOdd = "AnimationRowOdd";
            public const string AnimationSelectionTextField = "AnimationSelectionTextField";
            public const string AnimationTimelineTick = "AnimationTimelineTick";
            public const string AnimClipToolbar = "AnimClipToolbar";
            public const string AnimClipToolbarButton = "AnimClipToolbarButton";
            public const string AnimClipToolbarPopup = "AnimClipToolbarPopup";
            public const string AnimItemBackground = "AnimItemBackground";
            public const string AnimLeftPaneSeparator = "AnimLeftPaneSeparator";
            public const string AnimPlayToolbar = "AnimPlayToolbar";
            public const string AnimPropDropdown = "AnimPropDropdown";
            public const string AppCommand = "AppCommand";
            public const string AppCommandLeft = "AppCommandLeft";
            public const string AppCommandLeftOn = "AppCommandLeftOn";
            public const string AppCommandMid = "AppCommandMid";
            public const string AppCommandRight = "AppCommandRight";
            public const string AppToolbar = "AppToolbar";
            public const string AppToolbarButtonLeft = "AppToolbarButtonLeft";
            public const string AppToolbarButtonMid = "AppToolbarButtonMid";
            public const string AppToolbarButtonRight = "AppToolbarButtonRight";
            public const string ArrowNavigationLeft = "ArrowNavigationLeft";
            public const string ArrowNavigationRight = "ArrowNavigationRight";
            public const string AssetLabel = "AssetLabel";
            public const string AssetLabel_Icon = "AssetLabel Icon";
            public const string AssetLabel_Partial = "AssetLabel Partial";
            public const string AvatarMappingBox = "AvatarMappingBox";
            public const string AvatarMappingErrorLabel = "AvatarMappingErrorLabel";
            public const string AxisLabelNumberField = "AxisLabelNumberField";
            public const string Badge = "Badge";
            public const string BoldLabel = "BoldLabel";
            public const string BoldTextField = "BoldTextField";
            public const string BoldToggle = "BoldToggle";
            public const string BottomShadowInwards = "BottomShadowInwards";
            public const string BreadcrumbsSeparator = "BreadcrumbsSeparator";
            public const string ButtonLeft = "ButtonLeft";
            public const string ButtonMid = "ButtonMid";
            public const string ButtonRight = "ButtonRight";
            public const string BypassToggle = "BypassToggle";
            public const string CacheFolderLocation = "CacheFolderLocation";
            public const string CenteredLabel = "CenteredLabel";
            public const string ChannelStripAttenuationBar = "ChannelStripAttenuationBar";
            public const string ChannelStripAttenuationMarkerSquare = "ChannelStripAttenuationMarkerSquare";
            public const string ChannelStripBg = "ChannelStripBg";
            public const string ChannelStripDuckingMarker = "ChannelStripDuckingMarker";
            public const string ChannelStripEffectBar = "ChannelStripEffectBar";
            public const string ChannelStripSendReturnBar = "ChannelStripSendReturnBar";
            public const string ChannelStripVUMeterBg = "ChannelStripVUMeterBg";
            public const string CircularToggle = "CircularToggle";
            public const string CN_Box = "CN Box";
            public const string CN_CenteredText = "CN CenteredText";
            public const string CN_CountBadge = "CN CountBadge";
            public const string CN_EntryBackEven = "CN EntryBackEven";
            public const string CN_EntryBackOdd = "CN EntryBackOdd";
            public const string CN_EntryError = "CN EntryError";
            public const string CN_EntryErrorIcon = "CN EntryErrorIcon";
            public const string CN_EntryErrorIconSmall = "CN EntryErrorIconSmall";
            public const string CN_EntryErrorSmall = "CN EntryErrorSmall";
            public const string CN_EntryInfo = "CN EntryInfo";
            public const string CN_EntryInfoIcon = "CN EntryInfoIcon";
            public const string CN_EntryInfoIconSmall = "CN EntryInfoIconSmall";
            public const string CN_EntryInfoSmall = "CN EntryInfoSmall";
            public const string CN_EntryWarn = "CN EntryWarn";
            public const string CN_EntryWarnIcon = "CN EntryWarnIcon";
            public const string CN_EntryWarnIconSmall = "CN EntryWarnIconSmall";
            public const string CN_EntryWarnSmall = "CN EntryWarnSmall";
            public const string CN_Message = "CN Message";
            public const string CN_StacktraceBackground = "CN StacktraceBackground";
            public const string CN_StacktraceStyle = "CN StacktraceStyle";
            public const string CN_StatusError = "CN StatusError";
            public const string CN_StatusInfo = "CN StatusInfo";
            public const string CN_StatusWarn = "CN StatusWarn";
            public const string ColorField = "ColorField";
            public const string ColorPicker2DThumb = "ColorPicker2DThumb";
            public const string ColorPickerBackground = "ColorPickerBackground";
            public const string ColorPickerBox = "ColorPickerBox";
            public const string ColorPickerCurrentColor = "ColorPickerCurrentColor";
            public const string ColorPickerCurrentExposureSwatchBorder = "ColorPickerCurrentExposureSwatchBorder";
            public const string ColorPickerExposureSwatch = "ColorPickerExposureSwatch";
            public const string ColorPickerHorizThumb = "ColorPickerHorizThumb";
            public const string ColorPickerHueRing = "ColorPickerHueRing";
            public const string ColorPickerHueRing_HDR = "ColorPickerHueRing HDR";
            public const string ColorPickerHueRingThumb = "ColorPickerHueRingThumb";
            public const string ColorPickerOriginalColor = "ColorPickerOriginalColor";
            public const string ColorPickerSliderBackground = "ColorPickerSliderBackground";
            public const string Command = "Command";
            public const string CommandLeft = "CommandLeft";
            public const string CommandMid = "CommandMid";
            public const string CommandRight = "CommandRight";
            public const string ContentToolbar = "ContentToolbar";
            public const string ControlHighlight = "ControlHighlight";
            public const string ControlLabel = "ControlLabel";
            public const string CurveEditorBackground = "CurveEditorBackground";
            public const string CurveEditorLabelTickmarks = "CurveEditorLabelTickmarks";
            public const string CurveEditorLabelTickmarksOverflow = "CurveEditorLabelTickmarksOverflow";
            public const string CurveEditorRightAlignedLabel = "CurveEditorRightAlignedLabel";
            public const string DD_Background = "DD Background";
            public const string DD_HeaderStyle = "DD HeaderStyle";
            public const string DD_ItemCheckmark = "DD ItemCheckmark";
            public const string DD_ItemStyle = "DD ItemStyle";
            public const string DD_LargeItemStyle = "DD LargeItemStyle";
            public const string DefaultCenteredLargeText = "DefaultCenteredLargeText";
            public const string DefaultCenteredText = "DefaultCenteredText";
            public const string DefaultLineSeparator = "DefaultLineSeparator";
            public const string dockarea = "dockarea";
            public const string dockareaOverlay = "dockareaOverlay";
            public const string dockareaStandalone = "dockareaStandalone";
            public const string dockHeader = "dockHeader";
            public const string DopesheetBackground = "DopesheetBackground";
            public const string Dopesheetkeyframe = "Dopesheetkeyframe";
            public const string DopesheetRippleLeft = "DopesheetRippleLeft";
            public const string DopesheetRippleRight = "DopesheetRippleRight";
            public const string DopesheetScaleLeft = "DopesheetScaleLeft";
            public const string DopesheetScaleRight = "DopesheetScaleRight";
            public const string dragtab = "dragtab";
            public const string dragtab_first = "dragtab first";
            public const string dragtab_scroller_next = "dragtab scroller next";
            public const string dragtab_scroller_prev = "dragtab scroller prev";
            public const string dragtabdropwindow = "dragtabdropwindow";
            public const string DropDown = "DropDown";
            public const string DropDownButton = "DropDownButton";
            public const string DropzoneStyle = "DropzoneStyle";
            public const string EditModeSingleButton = "EditModeSingleButton";
            public const string ErrorLabel = "ErrorLabel";
            public const string ExposablePopupItem = "ExposablePopupItem";
            public const string ExposablePopupMenu = "ExposablePopupMenu";
            public const string EyeDropperHorizontalLine = "EyeDropperHorizontalLine";
            public const string EyeDropperPickedPixel = "EyeDropperPickedPixel";
            public const string EyeDropperVerticalLine = "EyeDropperVerticalLine";
            public const string FloatFieldLinkButton = "FloatFieldLinkButton";
            public const string flow_background = "flow background";
            public const string flow_node_0 = "flow node 0";
            public const string flow_node_0_on = "flow node 0 on";
            public const string flow_node_1 = "flow node 1";
            public const string flow_node_1_on = "flow node 1 on";
            public const string flow_node_2 = "flow node 2";
            public const string flow_node_2_on = "flow node 2 on";
            public const string flow_node_3 = "flow node 3";
            public const string flow_node_3_on = "flow node 3 on";
            public const string flow_node_4 = "flow node 4";
            public const string flow_node_4_on = "flow node 4 on";
            public const string flow_node_5 = "flow node 5";
            public const string flow_node_5_on = "flow node 5 on";
            public const string flow_node_6 = "flow node 6";
            public const string flow_node_6_on = "flow node 6 on";
            public const string flow_node_base = "flow node base";
            public const string flow_node_hex_0 = "flow node hex 0";
            public const string flow_node_hex_0_on = "flow node hex 0 on";
            public const string flow_node_hex_1 = "flow node hex 1";
            public const string flow_node_hex_1_on = "flow node hex 1 on";
            public const string flow_node_hex_2 = "flow node hex 2";
            public const string flow_node_hex_2_on = "flow node hex 2 on";
            public const string flow_node_hex_3 = "flow node hex 3";
            public const string flow_node_hex_3_on = "flow node hex 3 on";
            public const string flow_node_hex_4 = "flow node hex 4";
            public const string flow_node_hex_4_on = "flow node hex 4 on";
            public const string flow_node_hex_5 = "flow node hex 5";
            public const string flow_node_hex_5_on = "flow node hex 5 on";
            public const string flow_node_hex_6 = "flow node hex 6";
            public const string flow_node_hex_6_on = "flow node hex 6 on";
            public const string flow_node_hex_base = "flow node hex base";
            public const string flow_node_titlebar = "flow node titlebar";
            public const string flow_target_in = "flow target in";
            public const string flow_triggerPin_in = "flow triggerPin in";
            public const string flow_triggerPin_out = "flow triggerPin out";
            public const string flow_varPin_in = "flow varPin in";
            public const string flow_varPin_out = "flow varPin out";
            public const string flow_varPin_tooltip = "flow varPin tooltip";
            public const string Foldout = "Foldout";
            public const string FoldoutHeader = "FoldoutHeader";
            public const string FoldoutHeaderIcon = "FoldoutHeaderIcon";
            public const string FoldOutPreDrop = "FoldOutPreDrop";
            public const string Frame = "Frame";
            public const string FrameBox = "FrameBox";
            public const string GameViewBackground = "GameViewBackground";
            public const string Grad_Down_Swatch = "Grad Down Swatch";
            public const string Grad_Down_Swatch_Overlay = "Grad Down Swatch Overlay";
            public const string Grad_Up_Swatch = "Grad Up Swatch";
            public const string Grad_Up_Swatch_Overlay = "Grad Up Swatch Overlay";
            public const string grey_border = "grey_border";
            public const string GridList = "GridList";
            public const string GridListText = "GridListText";
            public const string GroupBox = "GroupBox";
            public const string GUIEditor_BreadcrumbLeft = "GUIEditor.BreadcrumbLeft";
            public const string GUIEditor_BreadcrumbLeftBackground = "GUIEditor.BreadcrumbLeftBackground";
            public const string GUIEditor_BreadcrumbMid = "GUIEditor.BreadcrumbMid";
            public const string GUIEditor_BreadcrumbMidBackground = "GUIEditor.BreadcrumbMidBackground";
            public const string GV_Gizmo_DropDown = "GV Gizmo DropDown";
            public const string HeaderButton = "HeaderButton";
            public const string HeaderLabel = "HeaderLabel";
            public const string HelpBox = "HelpBox";
            public const string Hi_Label = "Hi Label";
            public const string HorizontalMinMaxScrollbarThumb = "HorizontalMinMaxScrollbarThumb";
            public const string HorizontalSliderThumbExtent = "HorizontalSliderThumbExtent";
            public const string hostview = "hostview";
            public const string IconButton = "IconButton";
            public const string IN_BigTitle = "IN BigTitle";
            public const string IN_BigTitle_Inner = "IN BigTitle Inner";
            public const string IN_BigTitle_Post = "IN BigTitle Post";
            public const string IN_CenteredLabel = "IN CenteredLabel";
            public const string IN_DropDown = "IN DropDown";
            public const string IN_EditColliderButton = "IN EditColliderButton";
            public const string IN_Foldout = "IN Foldout";
            public const string IN_Footer = "IN Footer";
            public const string IN_Label = "IN Label";
            public const string IN_LockButton = "IN LockButton";
            public const string IN_MinMaxStateDropDown = "IN MinMaxStateDropDown";
            public const string IN_ObjectField = "IN ObjectField";
            public const string IN_TextField = "IN TextField";
            public const string IN_ThumbnailSelection = "IN ThumbnailSelection";
            public const string IN_ThumbnailShadow = "IN ThumbnailShadow";
            public const string IN_Title = "IN Title";
            public const string IN_Title_Flat = "IN Title Flat";
            public const string IN_TitleText = "IN TitleText";
            public const string IN_TypeSelection = "IN TypeSelection";
            public const string InnerShadowBg = "InnerShadowBg";
            public const string InsertionMarker = "InsertionMarker";
            public const string InvisibleButton = "InvisibleButton";
            public const string LargeBoldLabel = "LargeBoldLabel";
            public const string LargeButton = "LargeButton";
            public const string LargeButtonLeft = "LargeButtonLeft";
            public const string LargeButtonMid = "LargeButtonMid";
            public const string LargeButtonRight = "LargeButtonRight";
            public const string LargeLabel = "LargeLabel";
            public const string LightmapEditorSelectedHighlight = "LightmapEditorSelectedHighlight";
            public const string LinkLabel = "LinkLabel";
            public const string LODBlackBox = "LODBlackBox";
            public const string LODCameraLine = "LODCameraLine";
            public const string LODLevelNotifyText = "LODLevelNotifyText";
            public const string LODRendererAddButton = "LODRendererAddButton";
            public const string LODRendererButton = "LODRendererButton";
            public const string LODRendererRemove = "LODRendererRemove";
            public const string LODRenderersText = "LODRenderersText";
            public const string LODSceneText = "LODSceneText";
            public const string LODSliderBG = "LODSliderBG";
            public const string LODSliderRange = "LODSliderRange";
            public const string LODSliderRangeSelected = "LODSliderRangeSelected";
            public const string LODSliderText = "LODSliderText";
            public const string LODSliderTextSelected = "LODSliderTextSelected";
            public const string MeBlendBackground = "MeBlendBackground";
            public const string MeBlendPosition = "MeBlendPosition";
            public const string MeBlendTriangleLeft = "MeBlendTriangleLeft";
            public const string MeBlendTriangleRight = "MeBlendTriangleRight";
            public const string MeLivePlayBackground = "MeLivePlayBackground";
            public const string MeLivePlayBar = "MeLivePlayBar";
            public const string MenuItem = "MenuItem";
            public const string MenuItemMixed = "MenuItemMixed";
            public const string MenuToggleItem = "MenuToggleItem";
            public const string MeTimeBlockLeft = "MeTimeBlockLeft";
            public const string MeTimeBlockRight = "MeTimeBlockRight";
            public const string MeTimeLabel = "MeTimeLabel";
            public const string MeTransitionBack = "MeTransitionBack";
            public const string MeTransitionBlock = "MeTransitionBlock";
            public const string MeTransitionHandleLeft = "MeTransitionHandleLeft";
            public const string MeTransitionHandleLeftPrev = "MeTransitionHandleLeftPrev";
            public const string MeTransitionHandleRight = "MeTransitionHandleRight";
            public const string MeTransitionHead = "MeTransitionHead";
            public const string MeTransitionSelect = "MeTransitionSelect";
            public const string MeTransitionSelectHead = "MeTransitionSelectHead";
            public const string MeTransOff2On = "MeTransOff2On";
            public const string MeTransOffLeft = "MeTransOffLeft";
            public const string MeTransOffRight = "MeTransOffRight";
            public const string MeTransOn2Off = "MeTransOn2Off";
            public const string MeTransOnLeft = "MeTransOnLeft";
            public const string MeTransOnRight = "MeTransOnRight";
            public const string MeTransPlayhead = "MeTransPlayhead";
            public const string MiniBoldLabel = "MiniBoldLabel";
            public const string minibutton = "minibutton";
            public const string minibuttonleft = "minibuttonleft";
            public const string minibuttonmid = "minibuttonmid";
            public const string minibuttonright = "minibuttonright";
            public const string MiniLabel = "MiniLabel";
            public const string MiniMinMaxSliderHorizontal = "MiniMinMaxSliderHorizontal";
            public const string MiniMinMaxSliderVertical = "MiniMinMaxSliderVertical";
            public const string MiniPopup = "MiniPopup";
            public const string MiniPullDown = "MiniPullDown";
            public const string MiniSliderHorizontal = "MiniSliderHorizontal";
            public const string MiniSliderVertical = "MiniSliderVertical";
            public const string MiniTextField = "MiniTextField";
            public const string MiniToolbarButton = "MiniToolbarButton";
            public const string MiniToolbarButtonLeft = "MiniToolbarButtonLeft";
            public const string MinMaxHorizontalSliderThumb = "MinMaxHorizontalSliderThumb";
            public const string MultiColumnArrow = "MultiColumnArrow";
            public const string MultiColumnHeader = "MultiColumnHeader";
            public const string MultiColumnHeaderCenter = "MultiColumnHeaderCenter";
            public const string MultiColumnHeaderRight = "MultiColumnHeaderRight";
            public const string MultiColumnTopBar = "MultiColumnTopBar";
            public const string MuteToggle = "MuteToggle";
            public const string NotificationBackground = "NotificationBackground";
            public const string NotificationText = "NotificationText";
            public const string ObjectField = "ObjectField";
            public const string ObjectFieldButton = "ObjectFieldButton";
            public const string ObjectFieldMiniThumb = "ObjectFieldMiniThumb";
            public const string ObjectFieldThumb = "ObjectFieldThumb";
            public const string ObjectFieldThumbLightmapPreviewOverlay = "ObjectFieldThumbLightmapPreviewOverlay";
            public const string ObjectFieldThumbOverlay = "ObjectFieldThumbOverlay";
            public const string ObjectFieldThumbOverlay2 = "ObjectFieldThumbOverlay2";
            public const string ObjectPickerBackground = "ObjectPickerBackground";
            public const string ObjectPickerLargeStatus = "ObjectPickerLargeStatus";
            public const string ObjectPickerPreviewBackground = "ObjectPickerPreviewBackground";
            public const string ObjectPickerResultsEven = "ObjectPickerResultsEven";
            public const string ObjectPickerResultsGrid = "ObjectPickerResultsGrid";
            public const string ObjectPickerResultsOdd = "ObjectPickerResultsOdd";
            public const string ObjectPickerSmallStatus = "ObjectPickerSmallStatus";
            public const string ObjectPickerTab = "ObjectPickerTab";
            public const string ObjectPickerToolbar = "ObjectPickerToolbar";
            public const string OffsetDropDown = "OffsetDropDown";
            public const string OL_box = "OL box";
            public const string OL_box_flat = "OL box flat";
            public const string OL_box_NoExpand = "OL box NoExpand";
            public const string OL_EntryBackEven = "OL EntryBackEven";
            public const string OL_EntryBackOdd = "OL EntryBackOdd";
            public const string OL_Label = "OL Label";
            public const string OL_MiniPing = "OL MiniPing";
            public const string OL_MiniRenameField = "OL MiniRenameField";
            public const string OL_Minus = "OL Minus";
            public const string OL_Ping = "OL Ping";
            public const string OL_Plus = "OL Plus";
            public const string OL_ResultFocusMarker = "OL ResultFocusMarker";
            public const string OL_ResultLabel = "OL ResultLabel";
            public const string OL_RightLabel = "OL RightLabel";
            public const string OL_SelectedRow = "OL SelectedRow";
            public const string OL_Title = "OL Title";
            public const string OL_Title_TextRight = "OL Title TextRight";
            public const string OL_Toggle = "OL Toggle";
            public const string OL_ToggleMixed = "OL ToggleMixed";
            public const string OL_ToggleWhite = "OL ToggleWhite";
            public const string OT_BottomBar = "OT BottomBar";
            public const string OT_TopBar = "OT TopBar";
            public const string OverrideMargin = "OverrideMargin";
            public const string PaneOptions = "PaneOptions";
            public const string PlayerSettingsLevel = "PlayerSettingsLevel";
            public const string PlayerSettingsPlatform = "PlayerSettingsPlatform";
            public const string Popup = "Popup";
            public const string PopupCurveDropdown = "PopupCurveDropdown";
            public const string PopupCurveEditorBackground = "PopupCurveEditorBackground";
            public const string PopupCurveEditorSwatch = "PopupCurveEditorSwatch";
            public const string PopupCurveSwatchBackground = "PopupCurveSwatchBackground";
            public const string PR_BrokenPrefabLabel = "PR BrokenPrefabLabel";
            public const string PR_DisabledBrokenPrefabLabel = "PR DisabledBrokenPrefabLabel";
            public const string PR_DisabledLabel = "PR DisabledLabel";
            public const string PR_DisabledPrefabLabel = "PR DisabledPrefabLabel";
            public const string PR_Insertion = "PR Insertion";
            public const string PR_Label = "PR Label";
            public const string PR_Ping = "PR Ping";
            public const string PR_PrefabLabel = "PR PrefabLabel";
            public const string PR_TextField = "PR TextField";
            public const string PreBackground = "PreBackground";
            public const string PreBackgroundSolid = "PreBackgroundSolid";
            public const string PreButton = "PreButton";
            public const string PreButtonBlue = "PreButtonBlue";
            public const string PreButtonGreen = "PreButtonGreen";
            public const string PreButtonRed = "PreButtonRed";
            public const string PreDropDown = "PreDropDown";
            public const string PreferencesKeysElement = "PreferencesKeysElement";
            public const string PreferencesSection = "PreferencesSection";
            public const string PreferencesSectionBox = "PreferencesSectionBox";
            public const string PrefixLabel = "PrefixLabel";
            public const string PreHorizontalScrollbar = "PreHorizontalScrollbar";
            public const string PreHorizontalScrollbarThumb = "PreHorizontalScrollbarThumb";
            public const string PreLabel = "PreLabel";
            public const string PreLabelUpper = "PreLabelUpper";
            public const string PreMiniLabel = "PreMiniLabel";
            public const string PreOverlayLabel = "PreOverlayLabel";
            public const string PreSlider = "PreSlider";
            public const string PreSliderThumb = "PreSliderThumb";
            public const string PreToolbar = "PreToolbar";
            public const string PreToolbar2 = "PreToolbar2";
            public const string PreVerticalScrollbar = "PreVerticalScrollbar";
            public const string PreVerticalScrollbarThumb = "PreVerticalScrollbarThumb";
            public const string PreviewPackageInUse = "PreviewPackageInUse";
            public const string ProfilerBadge = "ProfilerBadge";
            public const string ProfilerDetailViewBackground = "ProfilerDetailViewBackground";
            public const string ProfilerGraphBackground = "ProfilerGraphBackground";
            public const string ProfilerHeaderLabel = "ProfilerHeaderLabel";
            public const string ProfilerLeftPane = "ProfilerLeftPane";
            public const string ProfilerNoDataAvailable = "ProfilerNoDataAvailable";
            public const string ProfilerNotSupportedWarningLabel = "ProfilerNotSupportedWarningLabel";
            public const string ProfilerPaneSubLabel = "ProfilerPaneSubLabel";
            public const string ProfilerRightPane = "ProfilerRightPane";
            public const string ProfilerScrollviewBackground = "ProfilerScrollviewBackground";
            public const string ProfilerSelectedLabel = "ProfilerSelectedLabel";
            public const string ProfilerTimelineBar = "ProfilerTimelineBar";
            public const string ProfilerTimelineDigDownArrow = "ProfilerTimelineDigDownArrow";
            public const string ProfilerTimelineFoldout = "ProfilerTimelineFoldout";
            public const string ProfilerTimelineLeftPane = "ProfilerTimelineLeftPane";
            public const string ProfilerTimelineRollUpArrow = "ProfilerTimelineRollUpArrow";
            public const string ProgressBarBack = "ProgressBarBack";
            public const string ProgressBarBar = "ProgressBarBar";
            public const string ProgressBarText = "ProgressBarText";
            public const string ProjectBrowserBottomBarBg = "ProjectBrowserBottomBarBg";
            public const string ProjectBrowserGridLabel = "ProjectBrowserGridLabel";
            public const string ProjectBrowserHeaderBgMiddle = "ProjectBrowserHeaderBgMiddle";
            public const string ProjectBrowserHeaderBgTop = "ProjectBrowserHeaderBgTop";
            public const string ProjectBrowserIconAreaBg = "ProjectBrowserIconAreaBg";
            public const string ProjectBrowserIconDropShadow = "ProjectBrowserIconDropShadow";
            public const string ProjectBrowserPreviewBg = "ProjectBrowserPreviewBg";
            public const string ProjectBrowserSubAssetBg = "ProjectBrowserSubAssetBg";
            public const string ProjectBrowserSubAssetBgCloseEnded = "ProjectBrowserSubAssetBgCloseEnded";
            public const string ProjectBrowserSubAssetBgDivider = "ProjectBrowserSubAssetBgDivider";
            public const string ProjectBrowserSubAssetBgMiddle = "ProjectBrowserSubAssetBgMiddle";
            public const string ProjectBrowserSubAssetBgOpenEnded = "ProjectBrowserSubAssetBgOpenEnded";
            public const string ProjectBrowserSubAssetExpandBtn = "ProjectBrowserSubAssetExpandBtn";
            public const string ProjectBrowserSubAssetExpandBtnMedium = "ProjectBrowserSubAssetExpandBtnMedium";
            public const string ProjectBrowserSubAssetExpandBtnSmall = "ProjectBrowserSubAssetExpandBtnSmall";
            public const string ProjectBrowserTextureIconDropShadow = "ProjectBrowserTextureIconDropShadow";
            public const string ProjectBrowserTopBarBg = "ProjectBrowserTopBarBg";
            public const string QualitySettingsDefault = "QualitySettingsDefault";
            public const string quick_search_tab = "quick search tab";
            public const string Radio = "Radio";
            public const string RectangleToolHBar = "RectangleToolHBar";
            public const string RectangleToolHBarLeft = "RectangleToolHBarLeft";
            public const string RectangleToolHBarRight = "RectangleToolHBarRight";
            public const string RectangleToolHighlight = "RectangleToolHighlight";
            public const string RectangleToolRippleLeft = "RectangleToolRippleLeft";
            public const string RectangleToolRippleRight = "RectangleToolRippleRight";
            public const string RectangleToolScaleBottom = "RectangleToolScaleBottom";
            public const string RectangleToolScaleLeft = "RectangleToolScaleLeft";
            public const string RectangleToolScaleRight = "RectangleToolScaleRight";
            public const string RectangleToolScaleTop = "RectangleToolScaleTop";
            public const string RectangleToolSelection = "RectangleToolSelection";
            public const string RectangleToolVBar = "RectangleToolVBar";
            public const string RectangleToolVBarBottom = "RectangleToolVBarBottom";
            public const string RectangleToolVBarTop = "RectangleToolVBarTop";
            public const string RegionBg = "RegionBg";
            public const string ReorderableList = "ReorderableList";
            public const string ReorderableListRightAligned = "ReorderableListRightAligned";
            public const string RightAlignedLabel = "RightAlignedLabel";
            public const string RightLabel = "RightLabel";
            public const string RL_Background = "RL Background";
            public const string RL_DragHandle = "RL DragHandle";
            public const string RL_Element = "RL Element";
            public const string RL_Empty_Header = "RL Empty Header";
            public const string RL_Footer = "RL Footer";
            public const string RL_FooterButton = "RL FooterButton";
            public const string RL_Header = "RL Header";
            public const string SC_ViewAxisLabel = "SC ViewAxisLabel";
            public const string SC_ViewLabel = "SC ViewLabel";
            public const string SC_ViewLabelCentered = "SC ViewLabelCentered";
            public const string SC_ViewLabelLeftAligned = "SC ViewLabelLeftAligned";
            public const string SceneTopBarBg = "SceneTopBarBg";
            public const string SceneViewOverlayTransparentBackground = "SceneViewOverlayTransparentBackground";
            public const string SceneVisibility = "SceneVisibility";
            public const string ScriptText = "ScriptText";
            public const string ScrollViewAlt = "ScrollViewAlt";
            public const string SearchCancelButton = "SearchCancelButton";
            public const string SearchCancelButtonEmpty = "SearchCancelButtonEmpty";
            public const string SearchModeFilter = "SearchModeFilter";
            public const string SearchTextField = "SearchTextField";
            public const string SelectionRect = "SelectionRect";
            public const string SettingsHeader = "SettingsHeader";
            public const string SettingsIconButton = "SettingsIconButton";
            public const string SettingsListItem = "SettingsListItem";
            public const string SettingsTreeItem = "SettingsTreeItem";
            public const string ShurikenCheckMark = "ShurikenCheckMark";
            public const string ShurikenCheckMarkMixed = "ShurikenCheckMarkMixed";
            public const string ShurikenDropdown = "ShurikenDropdown";
            public const string ShurikenEditableLabel = "ShurikenEditableLabel";
            public const string ShurikenEffectBg = "ShurikenEffectBg";
            public const string ShurikenEmitterTitle = "ShurikenEmitterTitle";
            public const string ShurikenLabel = "ShurikenLabel";
            public const string ShurikenMinus = "ShurikenMinus";
            public const string ShurikenModuleBg = "ShurikenModuleBg";
            public const string ShurikenModuleTitle = "ShurikenModuleTitle";
            public const string ShurikenObjectField = "ShurikenObjectField";
            public const string ShurikenPlus = "ShurikenPlus";
            public const string ShurikenPopup = "ShurikenPopup";
            public const string ShurikenToggle = "ShurikenToggle";
            public const string ShurikenToggleMixed = "ShurikenToggleMixed";
            public const string ShurikenValue = "ShurikenValue";
            public const string SliderMixed = "SliderMixed";
            public const string SoloToggle = "SoloToggle";
            public const string StaticDropdown = "StaticDropdown";
            public const string StatusBarIcon = "StatusBarIcon";
            public const string sv_iconselector_back = "sv_iconselector_back";
            public const string sv_iconselector_button = "sv_iconselector_button";
            public const string sv_iconselector_labelselection = "sv_iconselector_labelselection";
            public const string sv_iconselector_selection = "sv_iconselector_selection";
            public const string sv_iconselector_sep = "sv_iconselector_sep";
            public const string sv_label_0 = "sv_label_0";
            public const string sv_label_1 = "sv_label_1";
            public const string sv_label_2 = "sv_label_2";
            public const string sv_label_3 = "sv_label_3";
            public const string sv_label_4 = "sv_label_4";
            public const string sv_label_5 = "sv_label_5";
            public const string sv_label_6 = "sv_label_6";
            public const string sv_label_7 = "sv_label_7";
            public const string Tab_first = "Tab first";
            public const string Tab_last = "Tab last";
            public const string Tab_middle = "Tab middle";
            public const string Tab_onlyOne = "Tab onlyOne";
            public const string TabWindowBackground = "TabWindowBackground";
            public const string Tag_MenuItem = "Tag MenuItem";
            public const string TE_BoxBackground = "TE BoxBackground";
            public const string TE_DefaultTime = "TE DefaultTime";
            public const string TE_DropField = "TE DropField";
            public const string TE_ElementBackground = "TE ElementBackground";
            public const string TE_NodeBackground = "TE NodeBackground";
            public const string TE_NodeBox = "TE NodeBox";
            public const string TE_NodeBoxSelected = "TE NodeBoxSelected";
            public const string TE_NodeLabelBot = "TE NodeLabelBot";
            public const string TE_NodeLabelTop = "TE NodeLabelTop";
            public const string TE_PinLabel = "TE PinLabel";
            public const string TE_Toolbar = "TE Toolbar";
            public const string TE_toolbarbutton = "TE toolbarbutton";
            public const string TE_ToolbarDropDown = "TE ToolbarDropDown";
            public const string TextFieldDropDown = "TextFieldDropDown";
            public const string TextFieldDropDownText = "TextFieldDropDownText";
            public const string TimeAreaToolbar = "TimeAreaToolbar";
            public const string TimeRulerBackground = "TimeRulerBackground";
            public const string TimeScrubber = "TimeScrubber";
            public const string TimeScrubberButton = "TimeScrubberButton";
            public const string Titlebar_Foldout = "Titlebar Foldout";
            public const string TL_InPoint = "TL InPoint";
            public const string TL_OutPoint = "TL OutPoint";
            public const string TL_Playhead = "TL Playhead";
            public const string ToggleMixed = "ToggleMixed";
            public const string Toolbar = "Toolbar";
            public const string ToolbarBoldLabel = "ToolbarBoldLabel";
            public const string ToolbarBottom = "ToolbarBottom";
            public const string toolbarbutton = "toolbarbutton";
            public const string ToolbarButtonFlat = "ToolbarButtonFlat";
            public const string toolbarbuttonLeft = "toolbarbuttonLeft";
            public const string toolbarbuttonRight = "toolbarbuttonRight";
            public const string ToolbarCreateAddNewDropDown = "ToolbarCreateAddNewDropDown";
            public const string ToolbarDropDown = "ToolbarDropDown";
            public const string ToolbarDropDownLeft = "ToolbarDropDownLeft";
            public const string ToolbarDropDownRight = "ToolbarDropDownRight";
            public const string ToolbarDropDownToggle = "ToolbarDropDownToggle";
            public const string ToolbarDropDownToggleRight = "ToolbarDropDownToggleRight";
            public const string ToolbarLabel = "ToolbarLabel";
            public const string ToolbarPopup = "ToolbarPopup";
            public const string ToolbarPopupLeft = "ToolbarPopupLeft";
            public const string ToolbarPopupRight = "ToolbarPopupRight";
            public const string ToolbarSeachCancelButton = "ToolbarSeachCancelButton";
            public const string ToolbarSeachCancelButtonEmpty = "ToolbarSeachCancelButtonEmpty";
            public const string ToolbarSeachTextField = "ToolbarSeachTextField";
            public const string ToolbarSeachTextFieldPopup = "ToolbarSeachTextFieldPopup";
            public const string ToolbarSearchCancelButtonWithJump = "ToolbarSearchCancelButtonWithJump";
            public const string ToolbarSearchCancelButtonWithJumpEmpty = "ToolbarSearchCancelButtonWithJumpEmpty";
            public const string ToolbarSearchField = "ToolbarSearchField";
            public const string ToolbarSearchTextFieldJumpButton = "ToolbarSearchTextFieldJumpButton";
            public const string ToolbarSearchTextFieldWithJump = "ToolbarSearchTextFieldWithJump";
            public const string ToolbarSearchTextFieldWithJumpPopup = "ToolbarSearchTextFieldWithJumpPopup";
            public const string ToolbarSearchTextFieldWithJumpPopupSynced = "ToolbarSearchTextFieldWithJumpPopupSynced";
            public const string ToolbarSearchTextFieldWithJumpSynced = "ToolbarSearchTextFieldWithJumpSynced";
            public const string ToolbarSlider = "ToolbarSlider";
            public const string ToolbarSliderTextField = "ToolbarSliderTextField";
            public const string ToolbarTextField = "ToolbarTextField";
            public const string Tooltip = "Tooltip";
            public const string TV_Insertion = "TV Insertion";
            public const string TV_Line = "TV Line";
            public const string TV_LineBold = "TV LineBold";
            public const string TV_Ping = "TV Ping";
            public const string TV_Selection = "TV Selection";
            public const string U2D_createRect = "U2D.createRect";
            public const string U2D_dragDot = "U2D.dragDot";
            public const string U2D_dragDotActive = "U2D.dragDotActive";
            public const string U2D_dragDotDimmed = "U2D.dragDotDimmed";
            public const string U2D_pivotDot = "U2D.pivotDot";
            public const string U2D_pivotDotActive = "U2D.pivotDotActive";
            public const string VerticalMinMaxScrollbarThumb = "VerticalMinMaxScrollbarThumb";
            public const string VerticalSliderThumbExtent = "VerticalSliderThumbExtent";
            public const string VideoClipImporterLabel = "VideoClipImporterLabel";
            public const string WarningOverlay = "WarningOverlay";
            public const string WhiteBackground = "WhiteBackground";
            public const string WhiteBoldLabel = "WhiteBoldLabel";
            public const string WhiteLabel = "WhiteLabel";
            public const string WhiteLargeCenterLabel = "WhiteLargeCenterLabel";
            public const string WhiteLargeLabel = "WhiteLargeLabel";
            public const string WhiteMiniLabel = "WhiteMiniLabel";
            public const string WinBtn = "WinBtn";
            public const string WinBtnClose = "WinBtnClose";
            public const string WinBtnCloseMac = "WinBtnCloseMac";
            public const string WinBtnInactiveMac = "WinBtnInactiveMac";
            public const string WinBtnMax = "WinBtnMax";
            public const string WinBtnMaxMac = "WinBtnMaxMac";
            public const string WinBtnMinMac = "WinBtnMinMac";
            public const string WinBtnRestore = "WinBtnRestore";
            public const string WinBtnRestoreMac = "WinBtnRestoreMac";
            public const string WindowBottomResize = "WindowBottomResize";
            public const string Wizard_Box = "Wizard Box";
            public const string Wizard_Error = "Wizard Error";
            public const string WordWrapLabel = "WordWrapLabel";
            public const string wordwrapminibutton = "wordwrapminibutton";
            public const string WordWrappedLabel = "WordWrappedLabel";
            public const string WordWrappedMiniLabel = "WordWrappedMiniLabel";
        }

        public static class Game {
            public static GUIStyle box => Styles.Get(Keys.box, EditorSkin.Game);
            public static GUIStyle button => Styles.Get(Keys.button, EditorSkin.Game);
            public static GUIStyle toggle => Styles.Get(Keys.toggle, EditorSkin.Game);
            public static GUIStyle label => Styles.Get(Keys.label, EditorSkin.Game);
            public static GUIStyle window => Styles.Get(Keys.window, EditorSkin.Game);
            public static GUIStyle textfield => Styles.Get(Keys.textfield, EditorSkin.Game);
            public static GUIStyle textarea => Styles.Get(Keys.textarea, EditorSkin.Game);
            public static GUIStyle horizontalslider => Styles.Get(Keys.horizontalslider, EditorSkin.Game);
            public static GUIStyle horizontalsliderthumb => Styles.Get(Keys.horizontalsliderthumb, EditorSkin.Game);
            public static GUIStyle verticalslider => Styles.Get(Keys.verticalslider, EditorSkin.Game);
            public static GUIStyle verticalsliderthumb => Styles.Get(Keys.verticalsliderthumb, EditorSkin.Game);
            public static GUIStyle horizontalscrollbar => Styles.Get(Keys.horizontalscrollbar, EditorSkin.Game);

            public static GUIStyle horizontalscrollbarthumb =>
                Styles.Get(Keys.horizontalscrollbarthumb, EditorSkin.Game);

            public static GUIStyle horizontalscrollbarleftbutton =>
                Styles.Get(Keys.horizontalscrollbarleftbutton, EditorSkin.Game);

            public static GUIStyle horizontalscrollbarrightbutton =>
                Styles.Get(Keys.horizontalscrollbarrightbutton, EditorSkin.Game);

            public static GUIStyle verticalscrollbar => Styles.Get(Keys.verticalscrollbar, EditorSkin.Game);
            public static GUIStyle verticalscrollbarthumb => Styles.Get(Keys.verticalscrollbarthumb, EditorSkin.Game);

            public static GUIStyle verticalscrollbarupbutton =>
                Styles.Get(Keys.verticalscrollbarupbutton, EditorSkin.Game);

            public static GUIStyle verticalscrollbardownbutton =>
                Styles.Get(Keys.verticalscrollbardownbutton, EditorSkin.Game);

            public static GUIStyle scrollview => Styles.Get(Keys.scrollview, EditorSkin.Game);
            public static GUIStyle AboutWIndowLicenseLabel => Styles.Get(Keys.AboutWIndowLicenseLabel, EditorSkin.Game);
            public static GUIStyle AC_BoldHeader => Styles.Get(Keys.AC_BoldHeader, EditorSkin.Game);
            public static GUIStyle AC_Button => Styles.Get(Keys.AC_Button, EditorSkin.Game);
            public static GUIStyle AC_ComponentButton => Styles.Get(Keys.AC_ComponentButton, EditorSkin.Game);
            public static GUIStyle AC_GroupButton => Styles.Get(Keys.AC_GroupButton, EditorSkin.Game);
            public static GUIStyle AC_LeftArrow => Styles.Get(Keys.AC_LeftArrow, EditorSkin.Game);
            public static GUIStyle AC_PreviewHeader => Styles.Get(Keys.AC_PreviewHeader, EditorSkin.Game);
            public static GUIStyle AC_PreviewText => Styles.Get(Keys.AC_PreviewText, EditorSkin.Game);
            public static GUIStyle AC_RightArrow => Styles.Get(Keys.AC_RightArrow, EditorSkin.Game);

            public static GUIStyle AM_ChannelStripHeaderStyle =>
                Styles.Get(Keys.AM_ChannelStripHeaderStyle, EditorSkin.Game);

            public static GUIStyle AM_EffectName => Styles.Get(Keys.AM_EffectName, EditorSkin.Game);
            public static GUIStyle AM_HeaderStyle => Styles.Get(Keys.AM_HeaderStyle, EditorSkin.Game);
            public static GUIStyle AM_MixerHeader => Styles.Get(Keys.AM_MixerHeader, EditorSkin.Game);
            public static GUIStyle AM_MixerHeader2 => Styles.Get(Keys.AM_MixerHeader2, EditorSkin.Game);
            public static GUIStyle AM_ToolbarLabel => Styles.Get(Keys.AM_ToolbarLabel, EditorSkin.Game);
            public static GUIStyle AM_ToolbarObjectField => Styles.Get(Keys.AM_ToolbarObjectField, EditorSkin.Game);
            public static GUIStyle AM_TotalVuLabel => Styles.Get(Keys.AM_TotalVuLabel, EditorSkin.Game);
            public static GUIStyle AM_VuValue => Styles.Get(Keys.AM_VuValue, EditorSkin.Game);

            public static GUIStyle AnimationEventBackground =>
                Styles.Get(Keys.AnimationEventBackground, EditorSkin.Game);

            public static GUIStyle AnimationEventTooltip => Styles.Get(Keys.AnimationEventTooltip, EditorSkin.Game);

            public static GUIStyle AnimationEventTooltipArrow =>
                Styles.Get(Keys.AnimationEventTooltipArrow, EditorSkin.Game);

            public static GUIStyle AnimationKeyframeBackground =>
                Styles.Get(Keys.AnimationKeyframeBackground, EditorSkin.Game);

            public static GUIStyle AnimationPlayHead => Styles.Get(Keys.AnimationPlayHead, EditorSkin.Game);
            public static GUIStyle AnimationRowEven => Styles.Get(Keys.AnimationRowEven, EditorSkin.Game);
            public static GUIStyle AnimationRowOdd => Styles.Get(Keys.AnimationRowOdd, EditorSkin.Game);

            public static GUIStyle AnimationSelectionTextField =>
                Styles.Get(Keys.AnimationSelectionTextField, EditorSkin.Game);

            public static GUIStyle AnimationTimelineTick => Styles.Get(Keys.AnimationTimelineTick, EditorSkin.Game);
            public static GUIStyle AnimClipToolbar => Styles.Get(Keys.AnimClipToolbar, EditorSkin.Game);
            public static GUIStyle AnimClipToolbarButton => Styles.Get(Keys.AnimClipToolbarButton, EditorSkin.Game);
            public static GUIStyle AnimClipToolbarPopup => Styles.Get(Keys.AnimClipToolbarPopup, EditorSkin.Game);
            public static GUIStyle AnimItemBackground => Styles.Get(Keys.AnimItemBackground, EditorSkin.Game);
            public static GUIStyle AnimLeftPaneSeparator => Styles.Get(Keys.AnimLeftPaneSeparator, EditorSkin.Game);
            public static GUIStyle AnimPlayToolbar => Styles.Get(Keys.AnimPlayToolbar, EditorSkin.Game);
            public static GUIStyle AnimPropDropdown => Styles.Get(Keys.AnimPropDropdown, EditorSkin.Game);
            public static GUIStyle AppCommand => Styles.Get(Keys.AppCommand, EditorSkin.Game);
            public static GUIStyle AppCommandLeft => Styles.Get(Keys.AppCommandLeft, EditorSkin.Game);
            public static GUIStyle AppCommandLeftOn => Styles.Get(Keys.AppCommandLeftOn, EditorSkin.Game);
            public static GUIStyle AppCommandMid => Styles.Get(Keys.AppCommandMid, EditorSkin.Game);
            public static GUIStyle AppCommandRight => Styles.Get(Keys.AppCommandRight, EditorSkin.Game);
            public static GUIStyle AppToolbar => Styles.Get(Keys.AppToolbar, EditorSkin.Game);
            public static GUIStyle AppToolbarButtonLeft => Styles.Get(Keys.AppToolbarButtonLeft, EditorSkin.Game);
            public static GUIStyle AppToolbarButtonMid => Styles.Get(Keys.AppToolbarButtonMid, EditorSkin.Game);
            public static GUIStyle AppToolbarButtonRight => Styles.Get(Keys.AppToolbarButtonRight, EditorSkin.Game);
            public static GUIStyle ArrowNavigationLeft => Styles.Get(Keys.ArrowNavigationLeft, EditorSkin.Game);
            public static GUIStyle ArrowNavigationRight => Styles.Get(Keys.ArrowNavigationRight, EditorSkin.Game);
            public static GUIStyle AssetLabel => Styles.Get(Keys.AssetLabel, EditorSkin.Game);
            public static GUIStyle AssetLabel_Icon => Styles.Get(Keys.AssetLabel_Icon, EditorSkin.Game);
            public static GUIStyle AssetLabel_Partial => Styles.Get(Keys.AssetLabel_Partial, EditorSkin.Game);
            public static GUIStyle AvatarMappingBox => Styles.Get(Keys.AvatarMappingBox, EditorSkin.Game);
            public static GUIStyle AvatarMappingErrorLabel => Styles.Get(Keys.AvatarMappingErrorLabel, EditorSkin.Game);
            public static GUIStyle AxisLabelNumberField => Styles.Get(Keys.AxisLabelNumberField, EditorSkin.Game);
            public static GUIStyle Badge => Styles.Get(Keys.Badge, EditorSkin.Game);
            public static GUIStyle BoldLabel => Styles.Get(Keys.BoldLabel, EditorSkin.Game);
            public static GUIStyle BoldTextField => Styles.Get(Keys.BoldTextField, EditorSkin.Game);
            public static GUIStyle BoldToggle => Styles.Get(Keys.BoldToggle, EditorSkin.Game);
            public static GUIStyle BottomShadowInwards => Styles.Get(Keys.BottomShadowInwards, EditorSkin.Game);
            public static GUIStyle BreadcrumbsSeparator => Styles.Get(Keys.BreadcrumbsSeparator, EditorSkin.Game);
            public static GUIStyle ButtonLeft => Styles.Get(Keys.ButtonLeft, EditorSkin.Game);
            public static GUIStyle ButtonMid => Styles.Get(Keys.ButtonMid, EditorSkin.Game);
            public static GUIStyle ButtonRight => Styles.Get(Keys.ButtonRight, EditorSkin.Game);
            public static GUIStyle BypassToggle => Styles.Get(Keys.BypassToggle, EditorSkin.Game);
            public static GUIStyle CacheFolderLocation => Styles.Get(Keys.CacheFolderLocation, EditorSkin.Game);
            public static GUIStyle CenteredLabel => Styles.Get(Keys.CenteredLabel, EditorSkin.Game);

            public static GUIStyle ChannelStripAttenuationBar =>
                Styles.Get(Keys.ChannelStripAttenuationBar, EditorSkin.Game);

            public static GUIStyle ChannelStripAttenuationMarkerSquare =>
                Styles.Get(Keys.ChannelStripAttenuationMarkerSquare, EditorSkin.Game);

            public static GUIStyle ChannelStripBg => Styles.Get(Keys.ChannelStripBg, EditorSkin.Game);

            public static GUIStyle ChannelStripDuckingMarker =>
                Styles.Get(Keys.ChannelStripDuckingMarker, EditorSkin.Game);

            public static GUIStyle ChannelStripEffectBar => Styles.Get(Keys.ChannelStripEffectBar, EditorSkin.Game);

            public static GUIStyle ChannelStripSendReturnBar =>
                Styles.Get(Keys.ChannelStripSendReturnBar, EditorSkin.Game);

            public static GUIStyle ChannelStripVUMeterBg => Styles.Get(Keys.ChannelStripVUMeterBg, EditorSkin.Game);
            public static GUIStyle CircularToggle => Styles.Get(Keys.CircularToggle, EditorSkin.Game);
            public static GUIStyle CN_Box => Styles.Get(Keys.CN_Box, EditorSkin.Game);
            public static GUIStyle CN_CenteredText => Styles.Get(Keys.CN_CenteredText, EditorSkin.Game);
            public static GUIStyle CN_CountBadge => Styles.Get(Keys.CN_CountBadge, EditorSkin.Game);
            public static GUIStyle CN_EntryBackEven => Styles.Get(Keys.CN_EntryBackEven, EditorSkin.Game);
            public static GUIStyle CN_EntryBackOdd => Styles.Get(Keys.CN_EntryBackOdd, EditorSkin.Game);
            public static GUIStyle CN_EntryError => Styles.Get(Keys.CN_EntryError, EditorSkin.Game);
            public static GUIStyle CN_EntryErrorIcon => Styles.Get(Keys.CN_EntryErrorIcon, EditorSkin.Game);
            public static GUIStyle CN_EntryErrorIconSmall => Styles.Get(Keys.CN_EntryErrorIconSmall, EditorSkin.Game);
            public static GUIStyle CN_EntryErrorSmall => Styles.Get(Keys.CN_EntryErrorSmall, EditorSkin.Game);
            public static GUIStyle CN_EntryInfo => Styles.Get(Keys.CN_EntryInfo, EditorSkin.Game);
            public static GUIStyle CN_EntryInfoIcon => Styles.Get(Keys.CN_EntryInfoIcon, EditorSkin.Game);
            public static GUIStyle CN_EntryInfoIconSmall => Styles.Get(Keys.CN_EntryInfoIconSmall, EditorSkin.Game);
            public static GUIStyle CN_EntryInfoSmall => Styles.Get(Keys.CN_EntryInfoSmall, EditorSkin.Game);
            public static GUIStyle CN_EntryWarn => Styles.Get(Keys.CN_EntryWarn, EditorSkin.Game);
            public static GUIStyle CN_EntryWarnIcon => Styles.Get(Keys.CN_EntryWarnIcon, EditorSkin.Game);
            public static GUIStyle CN_EntryWarnIconSmall => Styles.Get(Keys.CN_EntryWarnIconSmall, EditorSkin.Game);
            public static GUIStyle CN_EntryWarnSmall => Styles.Get(Keys.CN_EntryWarnSmall, EditorSkin.Game);
            public static GUIStyle CN_Message => Styles.Get(Keys.CN_Message, EditorSkin.Game);
            public static GUIStyle CN_StacktraceBackground => Styles.Get(Keys.CN_StacktraceBackground, EditorSkin.Game);
            public static GUIStyle CN_StacktraceStyle => Styles.Get(Keys.CN_StacktraceStyle, EditorSkin.Game);
            public static GUIStyle CN_StatusError => Styles.Get(Keys.CN_StatusError, EditorSkin.Game);
            public static GUIStyle CN_StatusInfo => Styles.Get(Keys.CN_StatusInfo, EditorSkin.Game);
            public static GUIStyle CN_StatusWarn => Styles.Get(Keys.CN_StatusWarn, EditorSkin.Game);
            public static GUIStyle ColorField => Styles.Get(Keys.ColorField, EditorSkin.Game);
            public static GUIStyle ColorPicker2DThumb => Styles.Get(Keys.ColorPicker2DThumb, EditorSkin.Game);
            public static GUIStyle ColorPickerBackground => Styles.Get(Keys.ColorPickerBackground, EditorSkin.Game);
            public static GUIStyle ColorPickerBox => Styles.Get(Keys.ColorPickerBox, EditorSkin.Game);
            public static GUIStyle ColorPickerCurrentColor => Styles.Get(Keys.ColorPickerCurrentColor, EditorSkin.Game);

            public static GUIStyle ColorPickerCurrentExposureSwatchBorder =>
                Styles.Get(Keys.ColorPickerCurrentExposureSwatchBorder, EditorSkin.Game);

            public static GUIStyle ColorPickerExposureSwatch =>
                Styles.Get(Keys.ColorPickerExposureSwatch, EditorSkin.Game);

            public static GUIStyle ColorPickerHorizThumb => Styles.Get(Keys.ColorPickerHorizThumb, EditorSkin.Game);
            public static GUIStyle ColorPickerHueRing => Styles.Get(Keys.ColorPickerHueRing, EditorSkin.Game);
            public static GUIStyle ColorPickerHueRing_HDR => Styles.Get(Keys.ColorPickerHueRing_HDR, EditorSkin.Game);
            public static GUIStyle ColorPickerHueRingThumb => Styles.Get(Keys.ColorPickerHueRingThumb, EditorSkin.Game);

            public static GUIStyle ColorPickerOriginalColor =>
                Styles.Get(Keys.ColorPickerOriginalColor, EditorSkin.Game);

            public static GUIStyle ColorPickerSliderBackground =>
                Styles.Get(Keys.ColorPickerSliderBackground, EditorSkin.Game);

            public static GUIStyle Command => Styles.Get(Keys.Command, EditorSkin.Game);
            public static GUIStyle CommandLeft => Styles.Get(Keys.CommandLeft, EditorSkin.Game);
            public static GUIStyle CommandMid => Styles.Get(Keys.CommandMid, EditorSkin.Game);
            public static GUIStyle CommandRight => Styles.Get(Keys.CommandRight, EditorSkin.Game);
            public static GUIStyle ContentToolbar => Styles.Get(Keys.ContentToolbar, EditorSkin.Game);
            public static GUIStyle ControlHighlight => Styles.Get(Keys.ControlHighlight, EditorSkin.Game);
            public static GUIStyle ControlLabel => Styles.Get(Keys.ControlLabel, EditorSkin.Game);
            public static GUIStyle CurveEditorBackground => Styles.Get(Keys.CurveEditorBackground, EditorSkin.Game);

            public static GUIStyle CurveEditorLabelTickmarks =>
                Styles.Get(Keys.CurveEditorLabelTickmarks, EditorSkin.Game);

            public static GUIStyle CurveEditorLabelTickmarksOverflow =>
                Styles.Get(Keys.CurveEditorLabelTickmarksOverflow, EditorSkin.Game);

            public static GUIStyle CurveEditorRightAlignedLabel =>
                Styles.Get(Keys.CurveEditorRightAlignedLabel, EditorSkin.Game);

            public static GUIStyle DD_Background => Styles.Get(Keys.DD_Background, EditorSkin.Game);
            public static GUIStyle DD_HeaderStyle => Styles.Get(Keys.DD_HeaderStyle, EditorSkin.Game);
            public static GUIStyle DD_ItemCheckmark => Styles.Get(Keys.DD_ItemCheckmark, EditorSkin.Game);
            public static GUIStyle DD_ItemStyle => Styles.Get(Keys.DD_ItemStyle, EditorSkin.Game);
            public static GUIStyle DD_LargeItemStyle => Styles.Get(Keys.DD_LargeItemStyle, EditorSkin.Game);

            public static GUIStyle DefaultCenteredLargeText =>
                Styles.Get(Keys.DefaultCenteredLargeText, EditorSkin.Game);

            public static GUIStyle DefaultCenteredText => Styles.Get(Keys.DefaultCenteredText, EditorSkin.Game);
            public static GUIStyle DefaultLineSeparator => Styles.Get(Keys.DefaultLineSeparator, EditorSkin.Game);
            public static GUIStyle dockarea => Styles.Get(Keys.dockarea, EditorSkin.Game);
            public static GUIStyle dockareaOverlay => Styles.Get(Keys.dockareaOverlay, EditorSkin.Game);
            public static GUIStyle dockareaStandalone => Styles.Get(Keys.dockareaStandalone, EditorSkin.Game);
            public static GUIStyle dockHeader => Styles.Get(Keys.dockHeader, EditorSkin.Game);
            public static GUIStyle DopesheetBackground => Styles.Get(Keys.DopesheetBackground, EditorSkin.Game);
            public static GUIStyle Dopesheetkeyframe => Styles.Get(Keys.Dopesheetkeyframe, EditorSkin.Game);
            public static GUIStyle DopesheetRippleLeft => Styles.Get(Keys.DopesheetRippleLeft, EditorSkin.Game);
            public static GUIStyle DopesheetRippleRight => Styles.Get(Keys.DopesheetRippleRight, EditorSkin.Game);
            public static GUIStyle DopesheetScaleLeft => Styles.Get(Keys.DopesheetScaleLeft, EditorSkin.Game);
            public static GUIStyle DopesheetScaleRight => Styles.Get(Keys.DopesheetScaleRight, EditorSkin.Game);
            public static GUIStyle dragtab => Styles.Get(Keys.dragtab, EditorSkin.Game);
            public static GUIStyle dragtab_first => Styles.Get(Keys.dragtab_first, EditorSkin.Game);
            public static GUIStyle dragtab_scroller_next => Styles.Get(Keys.dragtab_scroller_next, EditorSkin.Game);
            public static GUIStyle dragtab_scroller_prev => Styles.Get(Keys.dragtab_scroller_prev, EditorSkin.Game);
            public static GUIStyle dragtabdropwindow => Styles.Get(Keys.dragtabdropwindow, EditorSkin.Game);
            public static GUIStyle DropDown => Styles.Get(Keys.DropDown, EditorSkin.Game);
            public static GUIStyle DropDownButton => Styles.Get(Keys.DropDownButton, EditorSkin.Game);
            public static GUIStyle DropzoneStyle => Styles.Get(Keys.DropzoneStyle, EditorSkin.Game);
            public static GUIStyle EditModeSingleButton => Styles.Get(Keys.EditModeSingleButton, EditorSkin.Game);
            public static GUIStyle ErrorLabel => Styles.Get(Keys.ErrorLabel, EditorSkin.Game);
            public static GUIStyle ExposablePopupItem => Styles.Get(Keys.ExposablePopupItem, EditorSkin.Game);
            public static GUIStyle ExposablePopupMenu => Styles.Get(Keys.ExposablePopupMenu, EditorSkin.Game);

            public static GUIStyle EyeDropperHorizontalLine =>
                Styles.Get(Keys.EyeDropperHorizontalLine, EditorSkin.Game);

            public static GUIStyle EyeDropperPickedPixel => Styles.Get(Keys.EyeDropperPickedPixel, EditorSkin.Game);
            public static GUIStyle EyeDropperVerticalLine => Styles.Get(Keys.EyeDropperVerticalLine, EditorSkin.Game);
            public static GUIStyle FloatFieldLinkButton => Styles.Get(Keys.FloatFieldLinkButton, EditorSkin.Game);
            public static GUIStyle flow_background => Styles.Get(Keys.flow_background, EditorSkin.Game);
            public static GUIStyle flow_node_0 => Styles.Get(Keys.flow_node_0, EditorSkin.Game);
            public static GUIStyle flow_node_0_on => Styles.Get(Keys.flow_node_0_on, EditorSkin.Game);
            public static GUIStyle flow_node_1 => Styles.Get(Keys.flow_node_1, EditorSkin.Game);
            public static GUIStyle flow_node_1_on => Styles.Get(Keys.flow_node_1_on, EditorSkin.Game);
            public static GUIStyle flow_node_2 => Styles.Get(Keys.flow_node_2, EditorSkin.Game);
            public static GUIStyle flow_node_2_on => Styles.Get(Keys.flow_node_2_on, EditorSkin.Game);
            public static GUIStyle flow_node_3 => Styles.Get(Keys.flow_node_3, EditorSkin.Game);
            public static GUIStyle flow_node_3_on => Styles.Get(Keys.flow_node_3_on, EditorSkin.Game);
            public static GUIStyle flow_node_4 => Styles.Get(Keys.flow_node_4, EditorSkin.Game);
            public static GUIStyle flow_node_4_on => Styles.Get(Keys.flow_node_4_on, EditorSkin.Game);
            public static GUIStyle flow_node_5 => Styles.Get(Keys.flow_node_5, EditorSkin.Game);
            public static GUIStyle flow_node_5_on => Styles.Get(Keys.flow_node_5_on, EditorSkin.Game);
            public static GUIStyle flow_node_6 => Styles.Get(Keys.flow_node_6, EditorSkin.Game);
            public static GUIStyle flow_node_6_on => Styles.Get(Keys.flow_node_6_on, EditorSkin.Game);
            public static GUIStyle flow_node_base => Styles.Get(Keys.flow_node_base, EditorSkin.Game);
            public static GUIStyle flow_node_hex_0 => Styles.Get(Keys.flow_node_hex_0, EditorSkin.Game);
            public static GUIStyle flow_node_hex_0_on => Styles.Get(Keys.flow_node_hex_0_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_1 => Styles.Get(Keys.flow_node_hex_1, EditorSkin.Game);
            public static GUIStyle flow_node_hex_1_on => Styles.Get(Keys.flow_node_hex_1_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_2 => Styles.Get(Keys.flow_node_hex_2, EditorSkin.Game);
            public static GUIStyle flow_node_hex_2_on => Styles.Get(Keys.flow_node_hex_2_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_3 => Styles.Get(Keys.flow_node_hex_3, EditorSkin.Game);
            public static GUIStyle flow_node_hex_3_on => Styles.Get(Keys.flow_node_hex_3_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_4 => Styles.Get(Keys.flow_node_hex_4, EditorSkin.Game);
            public static GUIStyle flow_node_hex_4_on => Styles.Get(Keys.flow_node_hex_4_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_5 => Styles.Get(Keys.flow_node_hex_5, EditorSkin.Game);
            public static GUIStyle flow_node_hex_5_on => Styles.Get(Keys.flow_node_hex_5_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_6 => Styles.Get(Keys.flow_node_hex_6, EditorSkin.Game);
            public static GUIStyle flow_node_hex_6_on => Styles.Get(Keys.flow_node_hex_6_on, EditorSkin.Game);
            public static GUIStyle flow_node_hex_base => Styles.Get(Keys.flow_node_hex_base, EditorSkin.Game);
            public static GUIStyle flow_node_titlebar => Styles.Get(Keys.flow_node_titlebar, EditorSkin.Game);
            public static GUIStyle flow_target_in => Styles.Get(Keys.flow_target_in, EditorSkin.Game);
            public static GUIStyle flow_triggerPin_in => Styles.Get(Keys.flow_triggerPin_in, EditorSkin.Game);
            public static GUIStyle flow_triggerPin_out => Styles.Get(Keys.flow_triggerPin_out, EditorSkin.Game);
            public static GUIStyle flow_varPin_in => Styles.Get(Keys.flow_varPin_in, EditorSkin.Game);
            public static GUIStyle flow_varPin_out => Styles.Get(Keys.flow_varPin_out, EditorSkin.Game);
            public static GUIStyle flow_varPin_tooltip => Styles.Get(Keys.flow_varPin_tooltip, EditorSkin.Game);
            public static GUIStyle Foldout => Styles.Get(Keys.Foldout, EditorSkin.Game);
            public static GUIStyle FoldoutHeader => Styles.Get(Keys.FoldoutHeader, EditorSkin.Game);
            public static GUIStyle FoldoutHeaderIcon => Styles.Get(Keys.FoldoutHeaderIcon, EditorSkin.Game);
            public static GUIStyle FoldOutPreDrop => Styles.Get(Keys.FoldOutPreDrop, EditorSkin.Game);
            public static GUIStyle Frame => Styles.Get(Keys.Frame, EditorSkin.Game);
            public static GUIStyle FrameBox => Styles.Get(Keys.FrameBox, EditorSkin.Game);
            public static GUIStyle GameViewBackground => Styles.Get(Keys.GameViewBackground, EditorSkin.Game);
            public static GUIStyle Grad_Down_Swatch => Styles.Get(Keys.Grad_Down_Swatch, EditorSkin.Game);

            public static GUIStyle Grad_Down_Swatch_Overlay =>
                Styles.Get(Keys.Grad_Down_Swatch_Overlay, EditorSkin.Game);

            public static GUIStyle Grad_Up_Swatch => Styles.Get(Keys.Grad_Up_Swatch, EditorSkin.Game);
            public static GUIStyle Grad_Up_Swatch_Overlay => Styles.Get(Keys.Grad_Up_Swatch_Overlay, EditorSkin.Game);
            public static GUIStyle grey_border => Styles.Get(Keys.grey_border, EditorSkin.Game);
            public static GUIStyle GridList => Styles.Get(Keys.GridList, EditorSkin.Game);
            public static GUIStyle GridListText => Styles.Get(Keys.GridListText, EditorSkin.Game);
            public static GUIStyle GroupBox => Styles.Get(Keys.GroupBox, EditorSkin.Game);

            public static GUIStyle GUIEditor_BreadcrumbLeft =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeft, EditorSkin.Game);

            public static GUIStyle GUIEditor_BreadcrumbLeftBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeftBackground, EditorSkin.Game);

            public static GUIStyle GUIEditor_BreadcrumbMid => Styles.Get(Keys.GUIEditor_BreadcrumbMid, EditorSkin.Game);

            public static GUIStyle GUIEditor_BreadcrumbMidBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbMidBackground, EditorSkin.Game);

            public static GUIStyle GV_Gizmo_DropDown => Styles.Get(Keys.GV_Gizmo_DropDown, EditorSkin.Game);
            public static GUIStyle HeaderButton => Styles.Get(Keys.HeaderButton, EditorSkin.Game);
            public static GUIStyle HeaderLabel => Styles.Get(Keys.HeaderLabel, EditorSkin.Game);
            public static GUIStyle HelpBox => Styles.Get(Keys.HelpBox, EditorSkin.Game);
            public static GUIStyle Hi_Label => Styles.Get(Keys.Hi_Label, EditorSkin.Game);

            public static GUIStyle HorizontalMinMaxScrollbarThumb =>
                Styles.Get(Keys.HorizontalMinMaxScrollbarThumb, EditorSkin.Game);

            public static GUIStyle HorizontalSliderThumbExtent =>
                Styles.Get(Keys.HorizontalSliderThumbExtent, EditorSkin.Game);

            public static GUIStyle hostview => Styles.Get(Keys.hostview, EditorSkin.Game);
            public static GUIStyle IconButton => Styles.Get(Keys.IconButton, EditorSkin.Game);
            public static GUIStyle IN_BigTitle => Styles.Get(Keys.IN_BigTitle, EditorSkin.Game);
            public static GUIStyle IN_BigTitle_Inner => Styles.Get(Keys.IN_BigTitle_Inner, EditorSkin.Game);
            public static GUIStyle IN_BigTitle_Post => Styles.Get(Keys.IN_BigTitle_Post, EditorSkin.Game);
            public static GUIStyle IN_CenteredLabel => Styles.Get(Keys.IN_CenteredLabel, EditorSkin.Game);
            public static GUIStyle IN_DropDown => Styles.Get(Keys.IN_DropDown, EditorSkin.Game);
            public static GUIStyle IN_EditColliderButton => Styles.Get(Keys.IN_EditColliderButton, EditorSkin.Game);
            public static GUIStyle IN_Foldout => Styles.Get(Keys.IN_Foldout, EditorSkin.Game);
            public static GUIStyle IN_Footer => Styles.Get(Keys.IN_Footer, EditorSkin.Game);
            public static GUIStyle IN_Label => Styles.Get(Keys.IN_Label, EditorSkin.Game);
            public static GUIStyle IN_LockButton => Styles.Get(Keys.IN_LockButton, EditorSkin.Game);
            public static GUIStyle IN_MinMaxStateDropDown => Styles.Get(Keys.IN_MinMaxStateDropDown, EditorSkin.Game);
            public static GUIStyle IN_ObjectField => Styles.Get(Keys.IN_ObjectField, EditorSkin.Game);
            public static GUIStyle IN_TextField => Styles.Get(Keys.IN_TextField, EditorSkin.Game);
            public static GUIStyle IN_ThumbnailSelection => Styles.Get(Keys.IN_ThumbnailSelection, EditorSkin.Game);
            public static GUIStyle IN_ThumbnailShadow => Styles.Get(Keys.IN_ThumbnailShadow, EditorSkin.Game);
            public static GUIStyle IN_Title => Styles.Get(Keys.IN_Title, EditorSkin.Game);
            public static GUIStyle IN_Title_Flat => Styles.Get(Keys.IN_Title_Flat, EditorSkin.Game);
            public static GUIStyle IN_TitleText => Styles.Get(Keys.IN_TitleText, EditorSkin.Game);
            public static GUIStyle IN_TypeSelection => Styles.Get(Keys.IN_TypeSelection, EditorSkin.Game);
            public static GUIStyle InnerShadowBg => Styles.Get(Keys.InnerShadowBg, EditorSkin.Game);
            public static GUIStyle InsertionMarker => Styles.Get(Keys.InsertionMarker, EditorSkin.Game);
            public static GUIStyle InvisibleButton => Styles.Get(Keys.InvisibleButton, EditorSkin.Game);
            public static GUIStyle LargeBoldLabel => Styles.Get(Keys.LargeBoldLabel, EditorSkin.Game);
            public static GUIStyle LargeButton => Styles.Get(Keys.LargeButton, EditorSkin.Game);
            public static GUIStyle LargeButtonLeft => Styles.Get(Keys.LargeButtonLeft, EditorSkin.Game);
            public static GUIStyle LargeButtonMid => Styles.Get(Keys.LargeButtonMid, EditorSkin.Game);
            public static GUIStyle LargeButtonRight => Styles.Get(Keys.LargeButtonRight, EditorSkin.Game);
            public static GUIStyle LargeLabel => Styles.Get(Keys.LargeLabel, EditorSkin.Game);

            public static GUIStyle LightmapEditorSelectedHighlight =>
                Styles.Get(Keys.LightmapEditorSelectedHighlight, EditorSkin.Game);

            public static GUIStyle LinkLabel => Styles.Get(Keys.LinkLabel, EditorSkin.Game);
            public static GUIStyle LODBlackBox => Styles.Get(Keys.LODBlackBox, EditorSkin.Game);
            public static GUIStyle LODCameraLine => Styles.Get(Keys.LODCameraLine, EditorSkin.Game);
            public static GUIStyle LODLevelNotifyText => Styles.Get(Keys.LODLevelNotifyText, EditorSkin.Game);
            public static GUIStyle LODRendererAddButton => Styles.Get(Keys.LODRendererAddButton, EditorSkin.Game);
            public static GUIStyle LODRendererButton => Styles.Get(Keys.LODRendererButton, EditorSkin.Game);
            public static GUIStyle LODRendererRemove => Styles.Get(Keys.LODRendererRemove, EditorSkin.Game);
            public static GUIStyle LODRenderersText => Styles.Get(Keys.LODRenderersText, EditorSkin.Game);
            public static GUIStyle LODSceneText => Styles.Get(Keys.LODSceneText, EditorSkin.Game);
            public static GUIStyle LODSliderBG => Styles.Get(Keys.LODSliderBG, EditorSkin.Game);
            public static GUIStyle LODSliderRange => Styles.Get(Keys.LODSliderRange, EditorSkin.Game);
            public static GUIStyle LODSliderRangeSelected => Styles.Get(Keys.LODSliderRangeSelected, EditorSkin.Game);
            public static GUIStyle LODSliderText => Styles.Get(Keys.LODSliderText, EditorSkin.Game);
            public static GUIStyle LODSliderTextSelected => Styles.Get(Keys.LODSliderTextSelected, EditorSkin.Game);
            public static GUIStyle MeBlendBackground => Styles.Get(Keys.MeBlendBackground, EditorSkin.Game);
            public static GUIStyle MeBlendPosition => Styles.Get(Keys.MeBlendPosition, EditorSkin.Game);
            public static GUIStyle MeBlendTriangleLeft => Styles.Get(Keys.MeBlendTriangleLeft, EditorSkin.Game);
            public static GUIStyle MeBlendTriangleRight => Styles.Get(Keys.MeBlendTriangleRight, EditorSkin.Game);
            public static GUIStyle MeLivePlayBackground => Styles.Get(Keys.MeLivePlayBackground, EditorSkin.Game);
            public static GUIStyle MeLivePlayBar => Styles.Get(Keys.MeLivePlayBar, EditorSkin.Game);
            public static GUIStyle MenuItem => Styles.Get(Keys.MenuItem, EditorSkin.Game);
            public static GUIStyle MenuItemMixed => Styles.Get(Keys.MenuItemMixed, EditorSkin.Game);
            public static GUIStyle MenuToggleItem => Styles.Get(Keys.MenuToggleItem, EditorSkin.Game);
            public static GUIStyle MeTimeBlockLeft => Styles.Get(Keys.MeTimeBlockLeft, EditorSkin.Game);
            public static GUIStyle MeTimeBlockRight => Styles.Get(Keys.MeTimeBlockRight, EditorSkin.Game);
            public static GUIStyle MeTimeLabel => Styles.Get(Keys.MeTimeLabel, EditorSkin.Game);
            public static GUIStyle MeTransitionBack => Styles.Get(Keys.MeTransitionBack, EditorSkin.Game);
            public static GUIStyle MeTransitionBlock => Styles.Get(Keys.MeTransitionBlock, EditorSkin.Game);
            public static GUIStyle MeTransitionHandleLeft => Styles.Get(Keys.MeTransitionHandleLeft, EditorSkin.Game);

            public static GUIStyle MeTransitionHandleLeftPrev =>
                Styles.Get(Keys.MeTransitionHandleLeftPrev, EditorSkin.Game);

            public static GUIStyle MeTransitionHandleRight => Styles.Get(Keys.MeTransitionHandleRight, EditorSkin.Game);
            public static GUIStyle MeTransitionHead => Styles.Get(Keys.MeTransitionHead, EditorSkin.Game);
            public static GUIStyle MeTransitionSelect => Styles.Get(Keys.MeTransitionSelect, EditorSkin.Game);
            public static GUIStyle MeTransitionSelectHead => Styles.Get(Keys.MeTransitionSelectHead, EditorSkin.Game);
            public static GUIStyle MeTransOff2On => Styles.Get(Keys.MeTransOff2On, EditorSkin.Game);
            public static GUIStyle MeTransOffLeft => Styles.Get(Keys.MeTransOffLeft, EditorSkin.Game);
            public static GUIStyle MeTransOffRight => Styles.Get(Keys.MeTransOffRight, EditorSkin.Game);
            public static GUIStyle MeTransOn2Off => Styles.Get(Keys.MeTransOn2Off, EditorSkin.Game);
            public static GUIStyle MeTransOnLeft => Styles.Get(Keys.MeTransOnLeft, EditorSkin.Game);
            public static GUIStyle MeTransOnRight => Styles.Get(Keys.MeTransOnRight, EditorSkin.Game);
            public static GUIStyle MeTransPlayhead => Styles.Get(Keys.MeTransPlayhead, EditorSkin.Game);
            public static GUIStyle MiniBoldLabel => Styles.Get(Keys.MiniBoldLabel, EditorSkin.Game);
            public static GUIStyle minibutton => Styles.Get(Keys.minibutton, EditorSkin.Game);
            public static GUIStyle minibuttonleft => Styles.Get(Keys.minibuttonleft, EditorSkin.Game);
            public static GUIStyle minibuttonmid => Styles.Get(Keys.minibuttonmid, EditorSkin.Game);
            public static GUIStyle minibuttonright => Styles.Get(Keys.minibuttonright, EditorSkin.Game);
            public static GUIStyle MiniLabel => Styles.Get(Keys.MiniLabel, EditorSkin.Game);

            public static GUIStyle MiniMinMaxSliderHorizontal =>
                Styles.Get(Keys.MiniMinMaxSliderHorizontal, EditorSkin.Game);

            public static GUIStyle MiniMinMaxSliderVertical =>
                Styles.Get(Keys.MiniMinMaxSliderVertical, EditorSkin.Game);

            public static GUIStyle MiniPopup => Styles.Get(Keys.MiniPopup, EditorSkin.Game);
            public static GUIStyle MiniPullDown => Styles.Get(Keys.MiniPullDown, EditorSkin.Game);
            public static GUIStyle MiniSliderHorizontal => Styles.Get(Keys.MiniSliderHorizontal, EditorSkin.Game);
            public static GUIStyle MiniSliderVertical => Styles.Get(Keys.MiniSliderVertical, EditorSkin.Game);
            public static GUIStyle MiniTextField => Styles.Get(Keys.MiniTextField, EditorSkin.Game);
            public static GUIStyle MiniToolbarButton => Styles.Get(Keys.MiniToolbarButton, EditorSkin.Game);
            public static GUIStyle MiniToolbarButtonLeft => Styles.Get(Keys.MiniToolbarButtonLeft, EditorSkin.Game);

            public static GUIStyle MinMaxHorizontalSliderThumb =>
                Styles.Get(Keys.MinMaxHorizontalSliderThumb, EditorSkin.Game);

            public static GUIStyle MultiColumnArrow => Styles.Get(Keys.MultiColumnArrow, EditorSkin.Game);
            public static GUIStyle MultiColumnHeader => Styles.Get(Keys.MultiColumnHeader, EditorSkin.Game);
            public static GUIStyle MultiColumnHeaderCenter => Styles.Get(Keys.MultiColumnHeaderCenter, EditorSkin.Game);
            public static GUIStyle MultiColumnHeaderRight => Styles.Get(Keys.MultiColumnHeaderRight, EditorSkin.Game);
            public static GUIStyle MultiColumnTopBar => Styles.Get(Keys.MultiColumnTopBar, EditorSkin.Game);
            public static GUIStyle MuteToggle => Styles.Get(Keys.MuteToggle, EditorSkin.Game);
            public static GUIStyle NotificationBackground => Styles.Get(Keys.NotificationBackground, EditorSkin.Game);
            public static GUIStyle NotificationText => Styles.Get(Keys.NotificationText, EditorSkin.Game);
            public static GUIStyle ObjectField => Styles.Get(Keys.ObjectField, EditorSkin.Game);
            public static GUIStyle ObjectFieldButton => Styles.Get(Keys.ObjectFieldButton, EditorSkin.Game);
            public static GUIStyle ObjectFieldMiniThumb => Styles.Get(Keys.ObjectFieldMiniThumb, EditorSkin.Game);
            public static GUIStyle ObjectFieldThumb => Styles.Get(Keys.ObjectFieldThumb, EditorSkin.Game);

            public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay =>
                Styles.Get(Keys.ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Game);

            public static GUIStyle ObjectFieldThumbOverlay => Styles.Get(Keys.ObjectFieldThumbOverlay, EditorSkin.Game);

            public static GUIStyle ObjectFieldThumbOverlay2 =>
                Styles.Get(Keys.ObjectFieldThumbOverlay2, EditorSkin.Game);

            public static GUIStyle ObjectPickerBackground => Styles.Get(Keys.ObjectPickerBackground, EditorSkin.Game);
            public static GUIStyle ObjectPickerLargeStatus => Styles.Get(Keys.ObjectPickerLargeStatus, EditorSkin.Game);

            public static GUIStyle ObjectPickerPreviewBackground =>
                Styles.Get(Keys.ObjectPickerPreviewBackground, EditorSkin.Game);

            public static GUIStyle ObjectPickerResultsEven => Styles.Get(Keys.ObjectPickerResultsEven, EditorSkin.Game);
            public static GUIStyle ObjectPickerResultsGrid => Styles.Get(Keys.ObjectPickerResultsGrid, EditorSkin.Game);
            public static GUIStyle ObjectPickerResultsOdd => Styles.Get(Keys.ObjectPickerResultsOdd, EditorSkin.Game);
            public static GUIStyle ObjectPickerSmallStatus => Styles.Get(Keys.ObjectPickerSmallStatus, EditorSkin.Game);
            public static GUIStyle ObjectPickerTab => Styles.Get(Keys.ObjectPickerTab, EditorSkin.Game);
            public static GUIStyle ObjectPickerToolbar => Styles.Get(Keys.ObjectPickerToolbar, EditorSkin.Game);
            public static GUIStyle OffsetDropDown => Styles.Get(Keys.OffsetDropDown, EditorSkin.Game);
            public static GUIStyle OL_box => Styles.Get(Keys.OL_box, EditorSkin.Game);
            public static GUIStyle OL_box_flat => Styles.Get(Keys.OL_box_flat, EditorSkin.Game);
            public static GUIStyle OL_box_NoExpand => Styles.Get(Keys.OL_box_NoExpand, EditorSkin.Game);
            public static GUIStyle OL_EntryBackEven => Styles.Get(Keys.OL_EntryBackEven, EditorSkin.Game);
            public static GUIStyle OL_EntryBackOdd => Styles.Get(Keys.OL_EntryBackOdd, EditorSkin.Game);
            public static GUIStyle OL_Label => Styles.Get(Keys.OL_Label, EditorSkin.Game);
            public static GUIStyle OL_MiniPing => Styles.Get(Keys.OL_MiniPing, EditorSkin.Game);
            public static GUIStyle OL_MiniRenameField => Styles.Get(Keys.OL_MiniRenameField, EditorSkin.Game);
            public static GUIStyle OL_Minus => Styles.Get(Keys.OL_Minus, EditorSkin.Game);
            public static GUIStyle OL_Ping => Styles.Get(Keys.OL_Ping, EditorSkin.Game);
            public static GUIStyle OL_Plus => Styles.Get(Keys.OL_Plus, EditorSkin.Game);
            public static GUIStyle OL_ResultFocusMarker => Styles.Get(Keys.OL_ResultFocusMarker, EditorSkin.Game);
            public static GUIStyle OL_ResultLabel => Styles.Get(Keys.OL_ResultLabel, EditorSkin.Game);
            public static GUIStyle OL_RightLabel => Styles.Get(Keys.OL_RightLabel, EditorSkin.Game);
            public static GUIStyle OL_SelectedRow => Styles.Get(Keys.OL_SelectedRow, EditorSkin.Game);
            public static GUIStyle OL_Title => Styles.Get(Keys.OL_Title, EditorSkin.Game);
            public static GUIStyle OL_Title_TextRight => Styles.Get(Keys.OL_Title_TextRight, EditorSkin.Game);
            public static GUIStyle OL_Toggle => Styles.Get(Keys.OL_Toggle, EditorSkin.Game);
            public static GUIStyle OL_ToggleMixed => Styles.Get(Keys.OL_ToggleMixed, EditorSkin.Game);
            public static GUIStyle OL_ToggleWhite => Styles.Get(Keys.OL_ToggleWhite, EditorSkin.Game);
            public static GUIStyle OT_BottomBar => Styles.Get(Keys.OT_BottomBar, EditorSkin.Game);
            public static GUIStyle OT_TopBar => Styles.Get(Keys.OT_TopBar, EditorSkin.Game);
            public static GUIStyle OverrideMargin => Styles.Get(Keys.OverrideMargin, EditorSkin.Game);
            public static GUIStyle PaneOptions => Styles.Get(Keys.PaneOptions, EditorSkin.Game);
            public static GUIStyle PlayerSettingsLevel => Styles.Get(Keys.PlayerSettingsLevel, EditorSkin.Game);
            public static GUIStyle PlayerSettingsPlatform => Styles.Get(Keys.PlayerSettingsPlatform, EditorSkin.Game);
            public static GUIStyle Popup => Styles.Get(Keys.Popup, EditorSkin.Game);
            public static GUIStyle PopupCurveDropdown => Styles.Get(Keys.PopupCurveDropdown, EditorSkin.Game);

            public static GUIStyle PopupCurveEditorBackground =>
                Styles.Get(Keys.PopupCurveEditorBackground, EditorSkin.Game);

            public static GUIStyle PopupCurveEditorSwatch => Styles.Get(Keys.PopupCurveEditorSwatch, EditorSkin.Game);

            public static GUIStyle PopupCurveSwatchBackground =>
                Styles.Get(Keys.PopupCurveSwatchBackground, EditorSkin.Game);

            public static GUIStyle PR_BrokenPrefabLabel => Styles.Get(Keys.PR_BrokenPrefabLabel, EditorSkin.Game);

            public static GUIStyle PR_DisabledBrokenPrefabLabel =>
                Styles.Get(Keys.PR_DisabledBrokenPrefabLabel, EditorSkin.Game);

            public static GUIStyle PR_DisabledLabel => Styles.Get(Keys.PR_DisabledLabel, EditorSkin.Game);
            public static GUIStyle PR_DisabledPrefabLabel => Styles.Get(Keys.PR_DisabledPrefabLabel, EditorSkin.Game);
            public static GUIStyle PR_Insertion => Styles.Get(Keys.PR_Insertion, EditorSkin.Game);
            public static GUIStyle PR_Label => Styles.Get(Keys.PR_Label, EditorSkin.Game);
            public static GUIStyle PR_Ping => Styles.Get(Keys.PR_Ping, EditorSkin.Game);
            public static GUIStyle PR_PrefabLabel => Styles.Get(Keys.PR_PrefabLabel, EditorSkin.Game);
            public static GUIStyle PR_TextField => Styles.Get(Keys.PR_TextField, EditorSkin.Game);
            public static GUIStyle PreBackground => Styles.Get(Keys.PreBackground, EditorSkin.Game);
            public static GUIStyle PreBackgroundSolid => Styles.Get(Keys.PreBackgroundSolid, EditorSkin.Game);
            public static GUIStyle PreButton => Styles.Get(Keys.PreButton, EditorSkin.Game);
            public static GUIStyle PreButtonBlue => Styles.Get(Keys.PreButtonBlue, EditorSkin.Game);
            public static GUIStyle PreButtonGreen => Styles.Get(Keys.PreButtonGreen, EditorSkin.Game);
            public static GUIStyle PreButtonRed => Styles.Get(Keys.PreButtonRed, EditorSkin.Game);
            public static GUIStyle PreDropDown => Styles.Get(Keys.PreDropDown, EditorSkin.Game);
            public static GUIStyle PreferencesKeysElement => Styles.Get(Keys.PreferencesKeysElement, EditorSkin.Game);
            public static GUIStyle PreferencesSection => Styles.Get(Keys.PreferencesSection, EditorSkin.Game);
            public static GUIStyle PreferencesSectionBox => Styles.Get(Keys.PreferencesSectionBox, EditorSkin.Game);
            public static GUIStyle PrefixLabel => Styles.Get(Keys.PrefixLabel, EditorSkin.Game);
            public static GUIStyle PreHorizontalScrollbar => Styles.Get(Keys.PreHorizontalScrollbar, EditorSkin.Game);

            public static GUIStyle PreHorizontalScrollbarThumb =>
                Styles.Get(Keys.PreHorizontalScrollbarThumb, EditorSkin.Game);

            public static GUIStyle PreLabel => Styles.Get(Keys.PreLabel, EditorSkin.Game);
            public static GUIStyle PreLabelUpper => Styles.Get(Keys.PreLabelUpper, EditorSkin.Game);
            public static GUIStyle PreMiniLabel => Styles.Get(Keys.PreMiniLabel, EditorSkin.Game);
            public static GUIStyle PreOverlayLabel => Styles.Get(Keys.PreOverlayLabel, EditorSkin.Game);
            public static GUIStyle PreSlider => Styles.Get(Keys.PreSlider, EditorSkin.Game);
            public static GUIStyle PreSliderThumb => Styles.Get(Keys.PreSliderThumb, EditorSkin.Game);
            public static GUIStyle PreToolbar => Styles.Get(Keys.PreToolbar, EditorSkin.Game);
            public static GUIStyle PreToolbar2 => Styles.Get(Keys.PreToolbar2, EditorSkin.Game);
            public static GUIStyle PreVerticalScrollbar => Styles.Get(Keys.PreVerticalScrollbar, EditorSkin.Game);

            public static GUIStyle PreVerticalScrollbarThumb =>
                Styles.Get(Keys.PreVerticalScrollbarThumb, EditorSkin.Game);

            public static GUIStyle PreviewPackageInUse => Styles.Get(Keys.PreviewPackageInUse, EditorSkin.Game);
            public static GUIStyle ProfilerBadge => Styles.Get(Keys.ProfilerBadge, EditorSkin.Game);

            public static GUIStyle ProfilerDetailViewBackground =>
                Styles.Get(Keys.ProfilerDetailViewBackground, EditorSkin.Game);

            public static GUIStyle ProfilerGraphBackground => Styles.Get(Keys.ProfilerGraphBackground, EditorSkin.Game);
            public static GUIStyle ProfilerHeaderLabel => Styles.Get(Keys.ProfilerHeaderLabel, EditorSkin.Game);
            public static GUIStyle ProfilerLeftPane => Styles.Get(Keys.ProfilerLeftPane, EditorSkin.Game);
            public static GUIStyle ProfilerNoDataAvailable => Styles.Get(Keys.ProfilerNoDataAvailable, EditorSkin.Game);

            public static GUIStyle ProfilerNotSupportedWarningLabel =>
                Styles.Get(Keys.ProfilerNotSupportedWarningLabel, EditorSkin.Game);

            public static GUIStyle ProfilerPaneSubLabel => Styles.Get(Keys.ProfilerPaneSubLabel, EditorSkin.Game);
            public static GUIStyle ProfilerRightPane => Styles.Get(Keys.ProfilerRightPane, EditorSkin.Game);

            public static GUIStyle ProfilerScrollviewBackground =>
                Styles.Get(Keys.ProfilerScrollviewBackground, EditorSkin.Game);

            public static GUIStyle ProfilerSelectedLabel => Styles.Get(Keys.ProfilerSelectedLabel, EditorSkin.Game);
            public static GUIStyle ProfilerTimelineBar => Styles.Get(Keys.ProfilerTimelineBar, EditorSkin.Game);

            public static GUIStyle ProfilerTimelineDigDownArrow =>
                Styles.Get(Keys.ProfilerTimelineDigDownArrow, EditorSkin.Game);

            public static GUIStyle ProfilerTimelineFoldout => Styles.Get(Keys.ProfilerTimelineFoldout, EditorSkin.Game);

            public static GUIStyle ProfilerTimelineLeftPane =>
                Styles.Get(Keys.ProfilerTimelineLeftPane, EditorSkin.Game);

            public static GUIStyle ProfilerTimelineRollUpArrow =>
                Styles.Get(Keys.ProfilerTimelineRollUpArrow, EditorSkin.Game);

            public static GUIStyle ProgressBarBack => Styles.Get(Keys.ProgressBarBack, EditorSkin.Game);
            public static GUIStyle ProgressBarBar => Styles.Get(Keys.ProgressBarBar, EditorSkin.Game);
            public static GUIStyle ProgressBarText => Styles.Get(Keys.ProgressBarText, EditorSkin.Game);

            public static GUIStyle ProjectBrowserBottomBarBg =>
                Styles.Get(Keys.ProjectBrowserBottomBarBg, EditorSkin.Game);

            public static GUIStyle ProjectBrowserGridLabel => Styles.Get(Keys.ProjectBrowserGridLabel, EditorSkin.Game);

            public static GUIStyle ProjectBrowserHeaderBgMiddle =>
                Styles.Get(Keys.ProjectBrowserHeaderBgMiddle, EditorSkin.Game);

            public static GUIStyle ProjectBrowserHeaderBgTop =>
                Styles.Get(Keys.ProjectBrowserHeaderBgTop, EditorSkin.Game);

            public static GUIStyle ProjectBrowserIconAreaBg =>
                Styles.Get(Keys.ProjectBrowserIconAreaBg, EditorSkin.Game);

            public static GUIStyle ProjectBrowserIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserIconDropShadow, EditorSkin.Game);

            public static GUIStyle ProjectBrowserPreviewBg => Styles.Get(Keys.ProjectBrowserPreviewBg, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetBg =>
                Styles.Get(Keys.ProjectBrowserSubAssetBg, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetBgCloseEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetBgDivider =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgDivider, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetBgMiddle =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgMiddle, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetBgOpenEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetExpandBtn =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtn, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Game);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Game);

            public static GUIStyle ProjectBrowserTextureIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserTextureIconDropShadow, EditorSkin.Game);

            public static GUIStyle ProjectBrowserTopBarBg => Styles.Get(Keys.ProjectBrowserTopBarBg, EditorSkin.Game);
            public static GUIStyle QualitySettingsDefault => Styles.Get(Keys.QualitySettingsDefault, EditorSkin.Game);
            public static GUIStyle quick_search_tab => Styles.Get(Keys.quick_search_tab, EditorSkin.Game);
            public static GUIStyle Radio => Styles.Get(Keys.Radio, EditorSkin.Game);
            public static GUIStyle RectangleToolHBar => Styles.Get(Keys.RectangleToolHBar, EditorSkin.Game);
            public static GUIStyle RectangleToolHBarLeft => Styles.Get(Keys.RectangleToolHBarLeft, EditorSkin.Game);
            public static GUIStyle RectangleToolHBarRight => Styles.Get(Keys.RectangleToolHBarRight, EditorSkin.Game);
            public static GUIStyle RectangleToolHighlight => Styles.Get(Keys.RectangleToolHighlight, EditorSkin.Game);
            public static GUIStyle RectangleToolRippleLeft => Styles.Get(Keys.RectangleToolRippleLeft, EditorSkin.Game);

            public static GUIStyle RectangleToolRippleRight =>
                Styles.Get(Keys.RectangleToolRippleRight, EditorSkin.Game);

            public static GUIStyle RectangleToolScaleBottom =>
                Styles.Get(Keys.RectangleToolScaleBottom, EditorSkin.Game);

            public static GUIStyle RectangleToolScaleLeft => Styles.Get(Keys.RectangleToolScaleLeft, EditorSkin.Game);
            public static GUIStyle RectangleToolScaleRight => Styles.Get(Keys.RectangleToolScaleRight, EditorSkin.Game);
            public static GUIStyle RectangleToolScaleTop => Styles.Get(Keys.RectangleToolScaleTop, EditorSkin.Game);
            public static GUIStyle RectangleToolSelection => Styles.Get(Keys.RectangleToolSelection, EditorSkin.Game);
            public static GUIStyle RectangleToolVBar => Styles.Get(Keys.RectangleToolVBar, EditorSkin.Game);
            public static GUIStyle RectangleToolVBarBottom => Styles.Get(Keys.RectangleToolVBarBottom, EditorSkin.Game);
            public static GUIStyle RectangleToolVBarTop => Styles.Get(Keys.RectangleToolVBarTop, EditorSkin.Game);
            public static GUIStyle RegionBg => Styles.Get(Keys.RegionBg, EditorSkin.Game);
            public static GUIStyle ReorderableList => Styles.Get(Keys.ReorderableList, EditorSkin.Game);

            public static GUIStyle ReorderableListRightAligned =>
                Styles.Get(Keys.ReorderableListRightAligned, EditorSkin.Game);

            public static GUIStyle RightAlignedLabel => Styles.Get(Keys.RightAlignedLabel, EditorSkin.Game);
            public static GUIStyle RightLabel => Styles.Get(Keys.RightLabel, EditorSkin.Game);
            public static GUIStyle RL_Background => Styles.Get(Keys.RL_Background, EditorSkin.Game);
            public static GUIStyle RL_DragHandle => Styles.Get(Keys.RL_DragHandle, EditorSkin.Game);
            public static GUIStyle RL_Element => Styles.Get(Keys.RL_Element, EditorSkin.Game);
            public static GUIStyle RL_Empty_Header => Styles.Get(Keys.RL_Empty_Header, EditorSkin.Game);
            public static GUIStyle RL_Footer => Styles.Get(Keys.RL_Footer, EditorSkin.Game);
            public static GUIStyle RL_FooterButton => Styles.Get(Keys.RL_FooterButton, EditorSkin.Game);
            public static GUIStyle RL_Header => Styles.Get(Keys.RL_Header, EditorSkin.Game);
            public static GUIStyle SC_ViewAxisLabel => Styles.Get(Keys.SC_ViewAxisLabel, EditorSkin.Game);
            public static GUIStyle SC_ViewLabel => Styles.Get(Keys.SC_ViewLabel, EditorSkin.Game);
            public static GUIStyle SC_ViewLabelCentered => Styles.Get(Keys.SC_ViewLabelCentered, EditorSkin.Game);
            public static GUIStyle SC_ViewLabelLeftAligned => Styles.Get(Keys.SC_ViewLabelLeftAligned, EditorSkin.Game);
            public static GUIStyle SceneTopBarBg => Styles.Get(Keys.SceneTopBarBg, EditorSkin.Game);

            public static GUIStyle SceneViewOverlayTransparentBackground =>
                Styles.Get(Keys.SceneViewOverlayTransparentBackground, EditorSkin.Game);

            public static GUIStyle SceneVisibility => Styles.Get(Keys.SceneVisibility, EditorSkin.Game);
            public static GUIStyle ScriptText => Styles.Get(Keys.ScriptText, EditorSkin.Game);
            public static GUIStyle ScrollViewAlt => Styles.Get(Keys.ScrollViewAlt, EditorSkin.Game);
            public static GUIStyle SearchCancelButton => Styles.Get(Keys.SearchCancelButton, EditorSkin.Game);
            public static GUIStyle SearchCancelButtonEmpty => Styles.Get(Keys.SearchCancelButtonEmpty, EditorSkin.Game);
            public static GUIStyle SearchModeFilter => Styles.Get(Keys.SearchModeFilter, EditorSkin.Game);
            public static GUIStyle SearchTextField => Styles.Get(Keys.SearchTextField, EditorSkin.Game);
            public static GUIStyle SelectionRect => Styles.Get(Keys.SelectionRect, EditorSkin.Game);
            public static GUIStyle SettingsHeader => Styles.Get(Keys.SettingsHeader, EditorSkin.Game);
            public static GUIStyle SettingsIconButton => Styles.Get(Keys.SettingsIconButton, EditorSkin.Game);
            public static GUIStyle SettingsListItem => Styles.Get(Keys.SettingsListItem, EditorSkin.Game);
            public static GUIStyle SettingsTreeItem => Styles.Get(Keys.SettingsTreeItem, EditorSkin.Game);
            public static GUIStyle ShurikenCheckMark => Styles.Get(Keys.ShurikenCheckMark, EditorSkin.Game);
            public static GUIStyle ShurikenCheckMarkMixed => Styles.Get(Keys.ShurikenCheckMarkMixed, EditorSkin.Game);
            public static GUIStyle ShurikenDropdown => Styles.Get(Keys.ShurikenDropdown, EditorSkin.Game);
            public static GUIStyle ShurikenEditableLabel => Styles.Get(Keys.ShurikenEditableLabel, EditorSkin.Game);
            public static GUIStyle ShurikenEffectBg => Styles.Get(Keys.ShurikenEffectBg, EditorSkin.Game);
            public static GUIStyle ShurikenEmitterTitle => Styles.Get(Keys.ShurikenEmitterTitle, EditorSkin.Game);
            public static GUIStyle ShurikenLabel => Styles.Get(Keys.ShurikenLabel, EditorSkin.Game);
            public static GUIStyle ShurikenMinus => Styles.Get(Keys.ShurikenMinus, EditorSkin.Game);
            public static GUIStyle ShurikenModuleBg => Styles.Get(Keys.ShurikenModuleBg, EditorSkin.Game);
            public static GUIStyle ShurikenModuleTitle => Styles.Get(Keys.ShurikenModuleTitle, EditorSkin.Game);
            public static GUIStyle ShurikenObjectField => Styles.Get(Keys.ShurikenObjectField, EditorSkin.Game);
            public static GUIStyle ShurikenPlus => Styles.Get(Keys.ShurikenPlus, EditorSkin.Game);
            public static GUIStyle ShurikenPopup => Styles.Get(Keys.ShurikenPopup, EditorSkin.Game);
            public static GUIStyle ShurikenToggle => Styles.Get(Keys.ShurikenToggle, EditorSkin.Game);
            public static GUIStyle ShurikenToggleMixed => Styles.Get(Keys.ShurikenToggleMixed, EditorSkin.Game);
            public static GUIStyle ShurikenValue => Styles.Get(Keys.ShurikenValue, EditorSkin.Game);
            public static GUIStyle SliderMixed => Styles.Get(Keys.SliderMixed, EditorSkin.Game);
            public static GUIStyle SoloToggle => Styles.Get(Keys.SoloToggle, EditorSkin.Game);
            public static GUIStyle StaticDropdown => Styles.Get(Keys.StaticDropdown, EditorSkin.Game);
            public static GUIStyle StatusBarIcon => Styles.Get(Keys.StatusBarIcon, EditorSkin.Game);
            public static GUIStyle sv_iconselector_back => Styles.Get(Keys.sv_iconselector_back, EditorSkin.Game);
            public static GUIStyle sv_iconselector_button => Styles.Get(Keys.sv_iconselector_button, EditorSkin.Game);

            public static GUIStyle sv_iconselector_labelselection =>
                Styles.Get(Keys.sv_iconselector_labelselection, EditorSkin.Game);

            public static GUIStyle sv_iconselector_selection =>
                Styles.Get(Keys.sv_iconselector_selection, EditorSkin.Game);

            public static GUIStyle sv_iconselector_sep => Styles.Get(Keys.sv_iconselector_sep, EditorSkin.Game);
            public static GUIStyle sv_label_0 => Styles.Get(Keys.sv_label_0, EditorSkin.Game);
            public static GUIStyle sv_label_1 => Styles.Get(Keys.sv_label_1, EditorSkin.Game);
            public static GUIStyle sv_label_2 => Styles.Get(Keys.sv_label_2, EditorSkin.Game);
            public static GUIStyle sv_label_3 => Styles.Get(Keys.sv_label_3, EditorSkin.Game);
            public static GUIStyle sv_label_4 => Styles.Get(Keys.sv_label_4, EditorSkin.Game);
            public static GUIStyle sv_label_5 => Styles.Get(Keys.sv_label_5, EditorSkin.Game);
            public static GUIStyle sv_label_6 => Styles.Get(Keys.sv_label_6, EditorSkin.Game);
            public static GUIStyle sv_label_7 => Styles.Get(Keys.sv_label_7, EditorSkin.Game);
            public static GUIStyle Tab_first => Styles.Get(Keys.Tab_first, EditorSkin.Game);
            public static GUIStyle Tab_last => Styles.Get(Keys.Tab_last, EditorSkin.Game);
            public static GUIStyle Tab_middle => Styles.Get(Keys.Tab_middle, EditorSkin.Game);
            public static GUIStyle Tab_onlyOne => Styles.Get(Keys.Tab_onlyOne, EditorSkin.Game);
            public static GUIStyle TabWindowBackground => Styles.Get(Keys.TabWindowBackground, EditorSkin.Game);
            public static GUIStyle Tag_MenuItem => Styles.Get(Keys.Tag_MenuItem, EditorSkin.Game);
            public static GUIStyle TE_BoxBackground => Styles.Get(Keys.TE_BoxBackground, EditorSkin.Game);
            public static GUIStyle TE_DefaultTime => Styles.Get(Keys.TE_DefaultTime, EditorSkin.Game);
            public static GUIStyle TE_DropField => Styles.Get(Keys.TE_DropField, EditorSkin.Game);
            public static GUIStyle TE_ElementBackground => Styles.Get(Keys.TE_ElementBackground, EditorSkin.Game);
            public static GUIStyle TE_NodeBackground => Styles.Get(Keys.TE_NodeBackground, EditorSkin.Game);
            public static GUIStyle TE_NodeBox => Styles.Get(Keys.TE_NodeBox, EditorSkin.Game);
            public static GUIStyle TE_NodeBoxSelected => Styles.Get(Keys.TE_NodeBoxSelected, EditorSkin.Game);
            public static GUIStyle TE_NodeLabelBot => Styles.Get(Keys.TE_NodeLabelBot, EditorSkin.Game);
            public static GUIStyle TE_NodeLabelTop => Styles.Get(Keys.TE_NodeLabelTop, EditorSkin.Game);
            public static GUIStyle TE_PinLabel => Styles.Get(Keys.TE_PinLabel, EditorSkin.Game);
            public static GUIStyle TE_Toolbar => Styles.Get(Keys.TE_Toolbar, EditorSkin.Game);
            public static GUIStyle TE_toolbarbutton => Styles.Get(Keys.TE_toolbarbutton, EditorSkin.Game);
            public static GUIStyle TE_ToolbarDropDown => Styles.Get(Keys.TE_ToolbarDropDown, EditorSkin.Game);
            public static GUIStyle TextFieldDropDown => Styles.Get(Keys.TextFieldDropDown, EditorSkin.Game);
            public static GUIStyle TextFieldDropDownText => Styles.Get(Keys.TextFieldDropDownText, EditorSkin.Game);
            public static GUIStyle TimeAreaToolbar => Styles.Get(Keys.TimeAreaToolbar, EditorSkin.Game);
            public static GUIStyle TimeRulerBackground => Styles.Get(Keys.TimeRulerBackground, EditorSkin.Game);
            public static GUIStyle TimeScrubber => Styles.Get(Keys.TimeScrubber, EditorSkin.Game);
            public static GUIStyle TimeScrubberButton => Styles.Get(Keys.TimeScrubberButton, EditorSkin.Game);
            public static GUIStyle Titlebar_Foldout => Styles.Get(Keys.Titlebar_Foldout, EditorSkin.Game);
            public static GUIStyle TL_InPoint => Styles.Get(Keys.TL_InPoint, EditorSkin.Game);
            public static GUIStyle TL_OutPoint => Styles.Get(Keys.TL_OutPoint, EditorSkin.Game);
            public static GUIStyle TL_Playhead => Styles.Get(Keys.TL_Playhead, EditorSkin.Game);
            public static GUIStyle ToggleMixed => Styles.Get(Keys.ToggleMixed, EditorSkin.Game);
            public static GUIStyle Toolbar => Styles.Get(Keys.Toolbar, EditorSkin.Game);
            public static GUIStyle ToolbarBoldLabel => Styles.Get(Keys.ToolbarBoldLabel, EditorSkin.Game);
            public static GUIStyle ToolbarBottom => Styles.Get(Keys.ToolbarBottom, EditorSkin.Game);
            public static GUIStyle toolbarbutton => Styles.Get(Keys.toolbarbutton, EditorSkin.Game);
            public static GUIStyle ToolbarButtonFlat => Styles.Get(Keys.ToolbarButtonFlat, EditorSkin.Game);
            public static GUIStyle toolbarbuttonLeft => Styles.Get(Keys.toolbarbuttonLeft, EditorSkin.Game);
            public static GUIStyle toolbarbuttonRight => Styles.Get(Keys.toolbarbuttonRight, EditorSkin.Game);

            public static GUIStyle ToolbarCreateAddNewDropDown =>
                Styles.Get(Keys.ToolbarCreateAddNewDropDown, EditorSkin.Game);

            public static GUIStyle ToolbarDropDown => Styles.Get(Keys.ToolbarDropDown, EditorSkin.Game);
            public static GUIStyle ToolbarDropDownLeft => Styles.Get(Keys.ToolbarDropDownLeft, EditorSkin.Game);
            public static GUIStyle ToolbarDropDownRight => Styles.Get(Keys.ToolbarDropDownRight, EditorSkin.Game);
            public static GUIStyle ToolbarDropDownToggle => Styles.Get(Keys.ToolbarDropDownToggle, EditorSkin.Game);

            public static GUIStyle ToolbarDropDownToggleRight =>
                Styles.Get(Keys.ToolbarDropDownToggleRight, EditorSkin.Game);

            public static GUIStyle ToolbarLabel => Styles.Get(Keys.ToolbarLabel, EditorSkin.Game);
            public static GUIStyle ToolbarPopup => Styles.Get(Keys.ToolbarPopup, EditorSkin.Game);
            public static GUIStyle ToolbarPopupLeft => Styles.Get(Keys.ToolbarPopupLeft, EditorSkin.Game);
            public static GUIStyle ToolbarPopupRight => Styles.Get(Keys.ToolbarPopupRight, EditorSkin.Game);

            public static GUIStyle ToolbarSeachCancelButton =>
                Styles.Get(Keys.ToolbarSeachCancelButton, EditorSkin.Game);

            public static GUIStyle ToolbarSeachCancelButtonEmpty =>
                Styles.Get(Keys.ToolbarSeachCancelButtonEmpty, EditorSkin.Game);

            public static GUIStyle ToolbarSeachTextField => Styles.Get(Keys.ToolbarSeachTextField, EditorSkin.Game);

            public static GUIStyle ToolbarSeachTextFieldPopup =>
                Styles.Get(Keys.ToolbarSeachTextFieldPopup, EditorSkin.Game);

            public static GUIStyle ToolbarSearchCancelButtonWithJump =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJump, EditorSkin.Game);

            public static GUIStyle ToolbarSearchCancelButtonWithJumpEmpty =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJumpEmpty, EditorSkin.Game);

            public static GUIStyle ToolbarSearchField => Styles.Get(Keys.ToolbarSearchField, EditorSkin.Game);

            public static GUIStyle ToolbarSearchTextFieldJumpButton =>
                Styles.Get(Keys.ToolbarSearchTextFieldJumpButton, EditorSkin.Game);

            public static GUIStyle ToolbarSearchTextFieldWithJump =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJump, EditorSkin.Game);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopup =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopup, EditorSkin.Game);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopupSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopupSynced, EditorSkin.Game);

            public static GUIStyle ToolbarSearchTextFieldWithJumpSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpSynced, EditorSkin.Game);

            public static GUIStyle ToolbarSlider => Styles.Get(Keys.ToolbarSlider, EditorSkin.Game);
            public static GUIStyle ToolbarSliderTextField => Styles.Get(Keys.ToolbarSliderTextField, EditorSkin.Game);
            public static GUIStyle ToolbarTextField => Styles.Get(Keys.ToolbarTextField, EditorSkin.Game);
            public static GUIStyle Tooltip => Styles.Get(Keys.Tooltip, EditorSkin.Game);
            public static GUIStyle TV_Insertion => Styles.Get(Keys.TV_Insertion, EditorSkin.Game);
            public static GUIStyle TV_Line => Styles.Get(Keys.TV_Line, EditorSkin.Game);
            public static GUIStyle TV_LineBold => Styles.Get(Keys.TV_LineBold, EditorSkin.Game);
            public static GUIStyle TV_Ping => Styles.Get(Keys.TV_Ping, EditorSkin.Game);
            public static GUIStyle TV_Selection => Styles.Get(Keys.TV_Selection, EditorSkin.Game);
            public static GUIStyle U2D_createRect => Styles.Get(Keys.U2D_createRect, EditorSkin.Game);
            public static GUIStyle U2D_dragDot => Styles.Get(Keys.U2D_dragDot, EditorSkin.Game);
            public static GUIStyle U2D_dragDotActive => Styles.Get(Keys.U2D_dragDotActive, EditorSkin.Game);
            public static GUIStyle U2D_dragDotDimmed => Styles.Get(Keys.U2D_dragDotDimmed, EditorSkin.Game);
            public static GUIStyle U2D_pivotDot => Styles.Get(Keys.U2D_pivotDot, EditorSkin.Game);
            public static GUIStyle U2D_pivotDotActive => Styles.Get(Keys.U2D_pivotDotActive, EditorSkin.Game);

            public static GUIStyle VerticalMinMaxScrollbarThumb =>
                Styles.Get(Keys.VerticalMinMaxScrollbarThumb, EditorSkin.Game);

            public static GUIStyle VerticalSliderThumbExtent =>
                Styles.Get(Keys.VerticalSliderThumbExtent, EditorSkin.Game);

            public static GUIStyle VideoClipImporterLabel => Styles.Get(Keys.VideoClipImporterLabel, EditorSkin.Game);
            public static GUIStyle WarningOverlay => Styles.Get(Keys.WarningOverlay, EditorSkin.Game);
            public static GUIStyle WhiteBackground => Styles.Get(Keys.WhiteBackground, EditorSkin.Game);
            public static GUIStyle WhiteBoldLabel => Styles.Get(Keys.WhiteBoldLabel, EditorSkin.Game);
            public static GUIStyle WhiteLabel => Styles.Get(Keys.WhiteLabel, EditorSkin.Game);
            public static GUIStyle WhiteLargeCenterLabel => Styles.Get(Keys.WhiteLargeCenterLabel, EditorSkin.Game);
            public static GUIStyle WhiteLargeLabel => Styles.Get(Keys.WhiteLargeLabel, EditorSkin.Game);
            public static GUIStyle WhiteMiniLabel => Styles.Get(Keys.WhiteMiniLabel, EditorSkin.Game);
            public static GUIStyle WinBtn => Styles.Get(Keys.WinBtn, EditorSkin.Game);
            public static GUIStyle WinBtnClose => Styles.Get(Keys.WinBtnClose, EditorSkin.Game);
            public static GUIStyle WinBtnCloseMac => Styles.Get(Keys.WinBtnCloseMac, EditorSkin.Game);
            public static GUIStyle WinBtnInactiveMac => Styles.Get(Keys.WinBtnInactiveMac, EditorSkin.Game);
            public static GUIStyle WinBtnMax => Styles.Get(Keys.WinBtnMax, EditorSkin.Game);
            public static GUIStyle WinBtnMaxMac => Styles.Get(Keys.WinBtnMaxMac, EditorSkin.Game);
            public static GUIStyle WinBtnMinMac => Styles.Get(Keys.WinBtnMinMac, EditorSkin.Game);
            public static GUIStyle WinBtnRestore => Styles.Get(Keys.WinBtnRestore, EditorSkin.Game);
            public static GUIStyle WinBtnRestoreMac => Styles.Get(Keys.WinBtnRestoreMac, EditorSkin.Game);
            public static GUIStyle WindowBottomResize => Styles.Get(Keys.WindowBottomResize, EditorSkin.Game);
            public static GUIStyle Wizard_Box => Styles.Get(Keys.Wizard_Box, EditorSkin.Game);
            public static GUIStyle Wizard_Error => Styles.Get(Keys.Wizard_Error, EditorSkin.Game);
            public static GUIStyle WordWrapLabel => Styles.Get(Keys.WordWrapLabel, EditorSkin.Game);
            public static GUIStyle wordwrapminibutton => Styles.Get(Keys.wordwrapminibutton, EditorSkin.Game);
            public static GUIStyle WordWrappedLabel => Styles.Get(Keys.WordWrappedLabel, EditorSkin.Game);
            public static GUIStyle WordWrappedMiniLabel => Styles.Get(Keys.WordWrappedMiniLabel, EditorSkin.Game);
        }

        public static class Inspector {
            public static GUIStyle box => Styles.Get(Keys.box, EditorSkin.Inspector);
            public static GUIStyle button => Styles.Get(Keys.button, EditorSkin.Inspector);
            public static GUIStyle toggle => Styles.Get(Keys.toggle, EditorSkin.Inspector);
            public static GUIStyle label => Styles.Get(Keys.label, EditorSkin.Inspector);
            public static GUIStyle window => Styles.Get(Keys.window, EditorSkin.Inspector);
            public static GUIStyle textfield => Styles.Get(Keys.textfield, EditorSkin.Inspector);
            public static GUIStyle textarea => Styles.Get(Keys.textarea, EditorSkin.Inspector);
            public static GUIStyle horizontalslider => Styles.Get(Keys.horizontalslider, EditorSkin.Inspector);

            public static GUIStyle horizontalsliderthumb =>
                Styles.Get(Keys.horizontalsliderthumb, EditorSkin.Inspector);

            public static GUIStyle verticalslider => Styles.Get(Keys.verticalslider, EditorSkin.Inspector);
            public static GUIStyle verticalsliderthumb => Styles.Get(Keys.verticalsliderthumb, EditorSkin.Inspector);
            public static GUIStyle horizontalscrollbar => Styles.Get(Keys.horizontalscrollbar, EditorSkin.Inspector);

            public static GUIStyle horizontalscrollbarthumb =>
                Styles.Get(Keys.horizontalscrollbarthumb, EditorSkin.Inspector);

            public static GUIStyle horizontalscrollbarleftbutton =>
                Styles.Get(Keys.horizontalscrollbarleftbutton, EditorSkin.Inspector);

            public static GUIStyle horizontalscrollbarrightbutton =>
                Styles.Get(Keys.horizontalscrollbarrightbutton, EditorSkin.Inspector);

            public static GUIStyle verticalscrollbar => Styles.Get(Keys.verticalscrollbar, EditorSkin.Inspector);

            public static GUIStyle verticalscrollbarthumb =>
                Styles.Get(Keys.verticalscrollbarthumb, EditorSkin.Inspector);

            public static GUIStyle verticalscrollbarupbutton =>
                Styles.Get(Keys.verticalscrollbarupbutton, EditorSkin.Inspector);

            public static GUIStyle verticalscrollbardownbutton =>
                Styles.Get(Keys.verticalscrollbardownbutton, EditorSkin.Inspector);

            public static GUIStyle scrollview => Styles.Get(Keys.scrollview, EditorSkin.Inspector);

            public static GUIStyle AboutWIndowLicenseLabel =>
                Styles.Get(Keys.AboutWIndowLicenseLabel, EditorSkin.Inspector);

            public static GUIStyle AC_BoldHeader => Styles.Get(Keys.AC_BoldHeader, EditorSkin.Inspector);
            public static GUIStyle AC_Button => Styles.Get(Keys.AC_Button, EditorSkin.Inspector);
            public static GUIStyle AC_ComponentButton => Styles.Get(Keys.AC_ComponentButton, EditorSkin.Inspector);
            public static GUIStyle AC_GroupButton => Styles.Get(Keys.AC_GroupButton, EditorSkin.Inspector);
            public static GUIStyle AC_LeftArrow => Styles.Get(Keys.AC_LeftArrow, EditorSkin.Inspector);
            public static GUIStyle AC_PreviewHeader => Styles.Get(Keys.AC_PreviewHeader, EditorSkin.Inspector);
            public static GUIStyle AC_PreviewText => Styles.Get(Keys.AC_PreviewText, EditorSkin.Inspector);
            public static GUIStyle AC_RightArrow => Styles.Get(Keys.AC_RightArrow, EditorSkin.Inspector);

            public static GUIStyle AM_ChannelStripHeaderStyle =>
                Styles.Get(Keys.AM_ChannelStripHeaderStyle, EditorSkin.Inspector);

            public static GUIStyle AM_EffectName => Styles.Get(Keys.AM_EffectName, EditorSkin.Inspector);
            public static GUIStyle AM_HeaderStyle => Styles.Get(Keys.AM_HeaderStyle, EditorSkin.Inspector);
            public static GUIStyle AM_MixerHeader => Styles.Get(Keys.AM_MixerHeader, EditorSkin.Inspector);
            public static GUIStyle AM_MixerHeader2 => Styles.Get(Keys.AM_MixerHeader2, EditorSkin.Inspector);
            public static GUIStyle AM_ToolbarLabel => Styles.Get(Keys.AM_ToolbarLabel, EditorSkin.Inspector);

            public static GUIStyle AM_ToolbarObjectField =>
                Styles.Get(Keys.AM_ToolbarObjectField, EditorSkin.Inspector);

            public static GUIStyle AM_TotalVuLabel => Styles.Get(Keys.AM_TotalVuLabel, EditorSkin.Inspector);
            public static GUIStyle AM_VuValue => Styles.Get(Keys.AM_VuValue, EditorSkin.Inspector);

            public static GUIStyle AnimationEventBackground =>
                Styles.Get(Keys.AnimationEventBackground, EditorSkin.Inspector);

            public static GUIStyle AnimationEventTooltip =>
                Styles.Get(Keys.AnimationEventTooltip, EditorSkin.Inspector);

            public static GUIStyle AnimationEventTooltipArrow =>
                Styles.Get(Keys.AnimationEventTooltipArrow, EditorSkin.Inspector);

            public static GUIStyle AnimationKeyframeBackground =>
                Styles.Get(Keys.AnimationKeyframeBackground, EditorSkin.Inspector);

            public static GUIStyle AnimationPlayHead => Styles.Get(Keys.AnimationPlayHead, EditorSkin.Inspector);
            public static GUIStyle AnimationRowEven => Styles.Get(Keys.AnimationRowEven, EditorSkin.Inspector);
            public static GUIStyle AnimationRowOdd => Styles.Get(Keys.AnimationRowOdd, EditorSkin.Inspector);

            public static GUIStyle AnimationSelectionTextField =>
                Styles.Get(Keys.AnimationSelectionTextField, EditorSkin.Inspector);

            public static GUIStyle AnimationTimelineTick =>
                Styles.Get(Keys.AnimationTimelineTick, EditorSkin.Inspector);

            public static GUIStyle AnimClipToolbar => Styles.Get(Keys.AnimClipToolbar, EditorSkin.Inspector);

            public static GUIStyle AnimClipToolbarButton =>
                Styles.Get(Keys.AnimClipToolbarButton, EditorSkin.Inspector);

            public static GUIStyle AnimClipToolbarPopup => Styles.Get(Keys.AnimClipToolbarPopup, EditorSkin.Inspector);
            public static GUIStyle AnimItemBackground => Styles.Get(Keys.AnimItemBackground, EditorSkin.Inspector);

            public static GUIStyle AnimLeftPaneSeparator =>
                Styles.Get(Keys.AnimLeftPaneSeparator, EditorSkin.Inspector);

            public static GUIStyle AnimPlayToolbar => Styles.Get(Keys.AnimPlayToolbar, EditorSkin.Inspector);
            public static GUIStyle AnimPropDropdown => Styles.Get(Keys.AnimPropDropdown, EditorSkin.Inspector);
            public static GUIStyle AppCommand => Styles.Get(Keys.AppCommand, EditorSkin.Inspector);
            public static GUIStyle AppCommandLeft => Styles.Get(Keys.AppCommandLeft, EditorSkin.Inspector);
            public static GUIStyle AppCommandLeftOn => Styles.Get(Keys.AppCommandLeftOn, EditorSkin.Inspector);
            public static GUIStyle AppCommandMid => Styles.Get(Keys.AppCommandMid, EditorSkin.Inspector);
            public static GUIStyle AppCommandRight => Styles.Get(Keys.AppCommandRight, EditorSkin.Inspector);
            public static GUIStyle AppToolbar => Styles.Get(Keys.AppToolbar, EditorSkin.Inspector);
            public static GUIStyle AppToolbarButtonLeft => Styles.Get(Keys.AppToolbarButtonLeft, EditorSkin.Inspector);
            public static GUIStyle AppToolbarButtonMid => Styles.Get(Keys.AppToolbarButtonMid, EditorSkin.Inspector);

            public static GUIStyle AppToolbarButtonRight =>
                Styles.Get(Keys.AppToolbarButtonRight, EditorSkin.Inspector);

            public static GUIStyle ArrowNavigationLeft => Styles.Get(Keys.ArrowNavigationLeft, EditorSkin.Inspector);
            public static GUIStyle ArrowNavigationRight => Styles.Get(Keys.ArrowNavigationRight, EditorSkin.Inspector);
            public static GUIStyle AssetLabel => Styles.Get(Keys.AssetLabel, EditorSkin.Inspector);
            public static GUIStyle AssetLabel_Icon => Styles.Get(Keys.AssetLabel_Icon, EditorSkin.Inspector);
            public static GUIStyle AssetLabel_Partial => Styles.Get(Keys.AssetLabel_Partial, EditorSkin.Inspector);
            public static GUIStyle AvatarMappingBox => Styles.Get(Keys.AvatarMappingBox, EditorSkin.Inspector);

            public static GUIStyle AvatarMappingErrorLabel =>
                Styles.Get(Keys.AvatarMappingErrorLabel, EditorSkin.Inspector);

            public static GUIStyle AxisLabelNumberField => Styles.Get(Keys.AxisLabelNumberField, EditorSkin.Inspector);
            public static GUIStyle Badge => Styles.Get(Keys.Badge, EditorSkin.Inspector);
            public static GUIStyle BoldLabel => Styles.Get(Keys.BoldLabel, EditorSkin.Inspector);
            public static GUIStyle BoldTextField => Styles.Get(Keys.BoldTextField, EditorSkin.Inspector);
            public static GUIStyle BoldToggle => Styles.Get(Keys.BoldToggle, EditorSkin.Inspector);
            public static GUIStyle BottomShadowInwards => Styles.Get(Keys.BottomShadowInwards, EditorSkin.Inspector);
            public static GUIStyle BreadcrumbsSeparator => Styles.Get(Keys.BreadcrumbsSeparator, EditorSkin.Inspector);
            public static GUIStyle ButtonLeft => Styles.Get(Keys.ButtonLeft, EditorSkin.Inspector);
            public static GUIStyle ButtonMid => Styles.Get(Keys.ButtonMid, EditorSkin.Inspector);
            public static GUIStyle ButtonRight => Styles.Get(Keys.ButtonRight, EditorSkin.Inspector);
            public static GUIStyle BypassToggle => Styles.Get(Keys.BypassToggle, EditorSkin.Inspector);
            public static GUIStyle CacheFolderLocation => Styles.Get(Keys.CacheFolderLocation, EditorSkin.Inspector);
            public static GUIStyle CenteredLabel => Styles.Get(Keys.CenteredLabel, EditorSkin.Inspector);

            public static GUIStyle ChannelStripAttenuationBar =>
                Styles.Get(Keys.ChannelStripAttenuationBar, EditorSkin.Inspector);

            public static GUIStyle ChannelStripAttenuationMarkerSquare =>
                Styles.Get(Keys.ChannelStripAttenuationMarkerSquare, EditorSkin.Inspector);

            public static GUIStyle ChannelStripBg => Styles.Get(Keys.ChannelStripBg, EditorSkin.Inspector);

            public static GUIStyle ChannelStripDuckingMarker =>
                Styles.Get(Keys.ChannelStripDuckingMarker, EditorSkin.Inspector);

            public static GUIStyle ChannelStripEffectBar =>
                Styles.Get(Keys.ChannelStripEffectBar, EditorSkin.Inspector);

            public static GUIStyle ChannelStripSendReturnBar =>
                Styles.Get(Keys.ChannelStripSendReturnBar, EditorSkin.Inspector);

            public static GUIStyle ChannelStripVUMeterBg =>
                Styles.Get(Keys.ChannelStripVUMeterBg, EditorSkin.Inspector);

            public static GUIStyle CircularToggle => Styles.Get(Keys.CircularToggle, EditorSkin.Inspector);
            public static GUIStyle CN_Box => Styles.Get(Keys.CN_Box, EditorSkin.Inspector);
            public static GUIStyle CN_CenteredText => Styles.Get(Keys.CN_CenteredText, EditorSkin.Inspector);
            public static GUIStyle CN_CountBadge => Styles.Get(Keys.CN_CountBadge, EditorSkin.Inspector);
            public static GUIStyle CN_EntryBackEven => Styles.Get(Keys.CN_EntryBackEven, EditorSkin.Inspector);
            public static GUIStyle CN_EntryBackOdd => Styles.Get(Keys.CN_EntryBackOdd, EditorSkin.Inspector);
            public static GUIStyle CN_EntryError => Styles.Get(Keys.CN_EntryError, EditorSkin.Inspector);
            public static GUIStyle CN_EntryErrorIcon => Styles.Get(Keys.CN_EntryErrorIcon, EditorSkin.Inspector);

            public static GUIStyle CN_EntryErrorIconSmall =>
                Styles.Get(Keys.CN_EntryErrorIconSmall, EditorSkin.Inspector);

            public static GUIStyle CN_EntryErrorSmall => Styles.Get(Keys.CN_EntryErrorSmall, EditorSkin.Inspector);
            public static GUIStyle CN_EntryInfo => Styles.Get(Keys.CN_EntryInfo, EditorSkin.Inspector);
            public static GUIStyle CN_EntryInfoIcon => Styles.Get(Keys.CN_EntryInfoIcon, EditorSkin.Inspector);

            public static GUIStyle CN_EntryInfoIconSmall =>
                Styles.Get(Keys.CN_EntryInfoIconSmall, EditorSkin.Inspector);

            public static GUIStyle CN_EntryInfoSmall => Styles.Get(Keys.CN_EntryInfoSmall, EditorSkin.Inspector);
            public static GUIStyle CN_EntryWarn => Styles.Get(Keys.CN_EntryWarn, EditorSkin.Inspector);
            public static GUIStyle CN_EntryWarnIcon => Styles.Get(Keys.CN_EntryWarnIcon, EditorSkin.Inspector);

            public static GUIStyle CN_EntryWarnIconSmall =>
                Styles.Get(Keys.CN_EntryWarnIconSmall, EditorSkin.Inspector);

            public static GUIStyle CN_EntryWarnSmall => Styles.Get(Keys.CN_EntryWarnSmall, EditorSkin.Inspector);
            public static GUIStyle CN_Message => Styles.Get(Keys.CN_Message, EditorSkin.Inspector);

            public static GUIStyle CN_StacktraceBackground =>
                Styles.Get(Keys.CN_StacktraceBackground, EditorSkin.Inspector);

            public static GUIStyle CN_StacktraceStyle => Styles.Get(Keys.CN_StacktraceStyle, EditorSkin.Inspector);
            public static GUIStyle CN_StatusError => Styles.Get(Keys.CN_StatusError, EditorSkin.Inspector);
            public static GUIStyle CN_StatusInfo => Styles.Get(Keys.CN_StatusInfo, EditorSkin.Inspector);
            public static GUIStyle CN_StatusWarn => Styles.Get(Keys.CN_StatusWarn, EditorSkin.Inspector);
            public static GUIStyle ColorField => Styles.Get(Keys.ColorField, EditorSkin.Inspector);
            public static GUIStyle ColorPicker2DThumb => Styles.Get(Keys.ColorPicker2DThumb, EditorSkin.Inspector);

            public static GUIStyle ColorPickerBackground =>
                Styles.Get(Keys.ColorPickerBackground, EditorSkin.Inspector);

            public static GUIStyle ColorPickerBox => Styles.Get(Keys.ColorPickerBox, EditorSkin.Inspector);

            public static GUIStyle ColorPickerCurrentColor =>
                Styles.Get(Keys.ColorPickerCurrentColor, EditorSkin.Inspector);

            public static GUIStyle ColorPickerCurrentExposureSwatchBorder =>
                Styles.Get(Keys.ColorPickerCurrentExposureSwatchBorder, EditorSkin.Inspector);

            public static GUIStyle ColorPickerExposureSwatch =>
                Styles.Get(Keys.ColorPickerExposureSwatch, EditorSkin.Inspector);

            public static GUIStyle ColorPickerHorizThumb =>
                Styles.Get(Keys.ColorPickerHorizThumb, EditorSkin.Inspector);

            public static GUIStyle ColorPickerHueRing => Styles.Get(Keys.ColorPickerHueRing, EditorSkin.Inspector);

            public static GUIStyle ColorPickerHueRing_HDR =>
                Styles.Get(Keys.ColorPickerHueRing_HDR, EditorSkin.Inspector);

            public static GUIStyle ColorPickerHueRingThumb =>
                Styles.Get(Keys.ColorPickerHueRingThumb, EditorSkin.Inspector);

            public static GUIStyle ColorPickerOriginalColor =>
                Styles.Get(Keys.ColorPickerOriginalColor, EditorSkin.Inspector);

            public static GUIStyle ColorPickerSliderBackground =>
                Styles.Get(Keys.ColorPickerSliderBackground, EditorSkin.Inspector);

            public static GUIStyle Command => Styles.Get(Keys.Command, EditorSkin.Inspector);
            public static GUIStyle CommandLeft => Styles.Get(Keys.CommandLeft, EditorSkin.Inspector);
            public static GUIStyle CommandMid => Styles.Get(Keys.CommandMid, EditorSkin.Inspector);
            public static GUIStyle CommandRight => Styles.Get(Keys.CommandRight, EditorSkin.Inspector);
            public static GUIStyle ContentToolbar => Styles.Get(Keys.ContentToolbar, EditorSkin.Inspector);
            public static GUIStyle ControlHighlight => Styles.Get(Keys.ControlHighlight, EditorSkin.Inspector);
            public static GUIStyle ControlLabel => Styles.Get(Keys.ControlLabel, EditorSkin.Inspector);

            public static GUIStyle CurveEditorBackground =>
                Styles.Get(Keys.CurveEditorBackground, EditorSkin.Inspector);

            public static GUIStyle CurveEditorLabelTickmarks =>
                Styles.Get(Keys.CurveEditorLabelTickmarks, EditorSkin.Inspector);

            public static GUIStyle CurveEditorLabelTickmarksOverflow =>
                Styles.Get(Keys.CurveEditorLabelTickmarksOverflow, EditorSkin.Inspector);

            public static GUIStyle CurveEditorRightAlignedLabel =>
                Styles.Get(Keys.CurveEditorRightAlignedLabel, EditorSkin.Inspector);

            public static GUIStyle DD_Background => Styles.Get(Keys.DD_Background, EditorSkin.Inspector);
            public static GUIStyle DD_HeaderStyle => Styles.Get(Keys.DD_HeaderStyle, EditorSkin.Inspector);
            public static GUIStyle DD_ItemCheckmark => Styles.Get(Keys.DD_ItemCheckmark, EditorSkin.Inspector);
            public static GUIStyle DD_ItemStyle => Styles.Get(Keys.DD_ItemStyle, EditorSkin.Inspector);
            public static GUIStyle DD_LargeItemStyle => Styles.Get(Keys.DD_LargeItemStyle, EditorSkin.Inspector);

            public static GUIStyle DefaultCenteredLargeText =>
                Styles.Get(Keys.DefaultCenteredLargeText, EditorSkin.Inspector);

            public static GUIStyle DefaultCenteredText => Styles.Get(Keys.DefaultCenteredText, EditorSkin.Inspector);
            public static GUIStyle DefaultLineSeparator => Styles.Get(Keys.DefaultLineSeparator, EditorSkin.Inspector);
            public static GUIStyle dockarea => Styles.Get(Keys.dockarea, EditorSkin.Inspector);
            public static GUIStyle dockareaOverlay => Styles.Get(Keys.dockareaOverlay, EditorSkin.Inspector);
            public static GUIStyle dockareaStandalone => Styles.Get(Keys.dockareaStandalone, EditorSkin.Inspector);
            public static GUIStyle dockHeader => Styles.Get(Keys.dockHeader, EditorSkin.Inspector);
            public static GUIStyle DopesheetBackground => Styles.Get(Keys.DopesheetBackground, EditorSkin.Inspector);
            public static GUIStyle Dopesheetkeyframe => Styles.Get(Keys.Dopesheetkeyframe, EditorSkin.Inspector);
            public static GUIStyle DopesheetRippleLeft => Styles.Get(Keys.DopesheetRippleLeft, EditorSkin.Inspector);
            public static GUIStyle DopesheetRippleRight => Styles.Get(Keys.DopesheetRippleRight, EditorSkin.Inspector);
            public static GUIStyle DopesheetScaleLeft => Styles.Get(Keys.DopesheetScaleLeft, EditorSkin.Inspector);
            public static GUIStyle DopesheetScaleRight => Styles.Get(Keys.DopesheetScaleRight, EditorSkin.Inspector);
            public static GUIStyle dragtab => Styles.Get(Keys.dragtab, EditorSkin.Inspector);
            public static GUIStyle dragtab_first => Styles.Get(Keys.dragtab_first, EditorSkin.Inspector);

            public static GUIStyle dragtab_scroller_next =>
                Styles.Get(Keys.dragtab_scroller_next, EditorSkin.Inspector);

            public static GUIStyle dragtab_scroller_prev =>
                Styles.Get(Keys.dragtab_scroller_prev, EditorSkin.Inspector);

            public static GUIStyle dragtabdropwindow => Styles.Get(Keys.dragtabdropwindow, EditorSkin.Inspector);
            public static GUIStyle DropDown => Styles.Get(Keys.DropDown, EditorSkin.Inspector);
            public static GUIStyle DropDownButton => Styles.Get(Keys.DropDownButton, EditorSkin.Inspector);
            public static GUIStyle DropzoneStyle => Styles.Get(Keys.DropzoneStyle, EditorSkin.Inspector);
            public static GUIStyle EditModeSingleButton => Styles.Get(Keys.EditModeSingleButton, EditorSkin.Inspector);
            public static GUIStyle ErrorLabel => Styles.Get(Keys.ErrorLabel, EditorSkin.Inspector);
            public static GUIStyle ExposablePopupItem => Styles.Get(Keys.ExposablePopupItem, EditorSkin.Inspector);
            public static GUIStyle ExposablePopupMenu => Styles.Get(Keys.ExposablePopupMenu, EditorSkin.Inspector);

            public static GUIStyle EyeDropperHorizontalLine =>
                Styles.Get(Keys.EyeDropperHorizontalLine, EditorSkin.Inspector);

            public static GUIStyle EyeDropperPickedPixel =>
                Styles.Get(Keys.EyeDropperPickedPixel, EditorSkin.Inspector);

            public static GUIStyle EyeDropperVerticalLine =>
                Styles.Get(Keys.EyeDropperVerticalLine, EditorSkin.Inspector);

            public static GUIStyle FloatFieldLinkButton => Styles.Get(Keys.FloatFieldLinkButton, EditorSkin.Inspector);
            public static GUIStyle flow_background => Styles.Get(Keys.flow_background, EditorSkin.Inspector);
            public static GUIStyle flow_node_0 => Styles.Get(Keys.flow_node_0, EditorSkin.Inspector);
            public static GUIStyle flow_node_0_on => Styles.Get(Keys.flow_node_0_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_1 => Styles.Get(Keys.flow_node_1, EditorSkin.Inspector);
            public static GUIStyle flow_node_1_on => Styles.Get(Keys.flow_node_1_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_2 => Styles.Get(Keys.flow_node_2, EditorSkin.Inspector);
            public static GUIStyle flow_node_2_on => Styles.Get(Keys.flow_node_2_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_3 => Styles.Get(Keys.flow_node_3, EditorSkin.Inspector);
            public static GUIStyle flow_node_3_on => Styles.Get(Keys.flow_node_3_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_4 => Styles.Get(Keys.flow_node_4, EditorSkin.Inspector);
            public static GUIStyle flow_node_4_on => Styles.Get(Keys.flow_node_4_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_5 => Styles.Get(Keys.flow_node_5, EditorSkin.Inspector);
            public static GUIStyle flow_node_5_on => Styles.Get(Keys.flow_node_5_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_6 => Styles.Get(Keys.flow_node_6, EditorSkin.Inspector);
            public static GUIStyle flow_node_6_on => Styles.Get(Keys.flow_node_6_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_base => Styles.Get(Keys.flow_node_base, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_0 => Styles.Get(Keys.flow_node_hex_0, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_0_on => Styles.Get(Keys.flow_node_hex_0_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_1 => Styles.Get(Keys.flow_node_hex_1, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_1_on => Styles.Get(Keys.flow_node_hex_1_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_2 => Styles.Get(Keys.flow_node_hex_2, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_2_on => Styles.Get(Keys.flow_node_hex_2_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_3 => Styles.Get(Keys.flow_node_hex_3, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_3_on => Styles.Get(Keys.flow_node_hex_3_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_4 => Styles.Get(Keys.flow_node_hex_4, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_4_on => Styles.Get(Keys.flow_node_hex_4_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_5 => Styles.Get(Keys.flow_node_hex_5, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_5_on => Styles.Get(Keys.flow_node_hex_5_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_6 => Styles.Get(Keys.flow_node_hex_6, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_6_on => Styles.Get(Keys.flow_node_hex_6_on, EditorSkin.Inspector);
            public static GUIStyle flow_node_hex_base => Styles.Get(Keys.flow_node_hex_base, EditorSkin.Inspector);
            public static GUIStyle flow_node_titlebar => Styles.Get(Keys.flow_node_titlebar, EditorSkin.Inspector);
            public static GUIStyle flow_target_in => Styles.Get(Keys.flow_target_in, EditorSkin.Inspector);
            public static GUIStyle flow_triggerPin_in => Styles.Get(Keys.flow_triggerPin_in, EditorSkin.Inspector);
            public static GUIStyle flow_triggerPin_out => Styles.Get(Keys.flow_triggerPin_out, EditorSkin.Inspector);
            public static GUIStyle flow_varPin_in => Styles.Get(Keys.flow_varPin_in, EditorSkin.Inspector);
            public static GUIStyle flow_varPin_out => Styles.Get(Keys.flow_varPin_out, EditorSkin.Inspector);
            public static GUIStyle flow_varPin_tooltip => Styles.Get(Keys.flow_varPin_tooltip, EditorSkin.Inspector);
            public static GUIStyle Foldout => Styles.Get(Keys.Foldout, EditorSkin.Inspector);
            public static GUIStyle FoldoutHeader => Styles.Get(Keys.FoldoutHeader, EditorSkin.Inspector);
            public static GUIStyle FoldoutHeaderIcon => Styles.Get(Keys.FoldoutHeaderIcon, EditorSkin.Inspector);
            public static GUIStyle FoldOutPreDrop => Styles.Get(Keys.FoldOutPreDrop, EditorSkin.Inspector);
            public static GUIStyle Frame => Styles.Get(Keys.Frame, EditorSkin.Inspector);
            public static GUIStyle FrameBox => Styles.Get(Keys.FrameBox, EditorSkin.Inspector);
            public static GUIStyle GameViewBackground => Styles.Get(Keys.GameViewBackground, EditorSkin.Inspector);
            public static GUIStyle Grad_Down_Swatch => Styles.Get(Keys.Grad_Down_Swatch, EditorSkin.Inspector);

            public static GUIStyle Grad_Down_Swatch_Overlay =>
                Styles.Get(Keys.Grad_Down_Swatch_Overlay, EditorSkin.Inspector);

            public static GUIStyle Grad_Up_Swatch => Styles.Get(Keys.Grad_Up_Swatch, EditorSkin.Inspector);

            public static GUIStyle Grad_Up_Swatch_Overlay =>
                Styles.Get(Keys.Grad_Up_Swatch_Overlay, EditorSkin.Inspector);

            public static GUIStyle grey_border => Styles.Get(Keys.grey_border, EditorSkin.Inspector);
            public static GUIStyle GridList => Styles.Get(Keys.GridList, EditorSkin.Inspector);
            public static GUIStyle GridListText => Styles.Get(Keys.GridListText, EditorSkin.Inspector);
            public static GUIStyle GroupBox => Styles.Get(Keys.GroupBox, EditorSkin.Inspector);

            public static GUIStyle GUIEditor_BreadcrumbLeft =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeft, EditorSkin.Inspector);

            public static GUIStyle GUIEditor_BreadcrumbLeftBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeftBackground, EditorSkin.Inspector);

            public static GUIStyle GUIEditor_BreadcrumbMid =>
                Styles.Get(Keys.GUIEditor_BreadcrumbMid, EditorSkin.Inspector);

            public static GUIStyle GUIEditor_BreadcrumbMidBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbMidBackground, EditorSkin.Inspector);

            public static GUIStyle GV_Gizmo_DropDown => Styles.Get(Keys.GV_Gizmo_DropDown, EditorSkin.Inspector);
            public static GUIStyle HeaderButton => Styles.Get(Keys.HeaderButton, EditorSkin.Inspector);
            public static GUIStyle HeaderLabel => Styles.Get(Keys.HeaderLabel, EditorSkin.Inspector);
            public static GUIStyle HelpBox => Styles.Get(Keys.HelpBox, EditorSkin.Inspector);
            public static GUIStyle Hi_Label => Styles.Get(Keys.Hi_Label, EditorSkin.Inspector);

            public static GUIStyle HorizontalMinMaxScrollbarThumb =>
                Styles.Get(Keys.HorizontalMinMaxScrollbarThumb, EditorSkin.Inspector);

            public static GUIStyle HorizontalSliderThumbExtent =>
                Styles.Get(Keys.HorizontalSliderThumbExtent, EditorSkin.Inspector);

            public static GUIStyle hostview => Styles.Get(Keys.hostview, EditorSkin.Inspector);
            public static GUIStyle IconButton => Styles.Get(Keys.IconButton, EditorSkin.Inspector);
            public static GUIStyle IN_BigTitle => Styles.Get(Keys.IN_BigTitle, EditorSkin.Inspector);
            public static GUIStyle IN_BigTitle_Inner => Styles.Get(Keys.IN_BigTitle_Inner, EditorSkin.Inspector);
            public static GUIStyle IN_BigTitle_Post => Styles.Get(Keys.IN_BigTitle_Post, EditorSkin.Inspector);
            public static GUIStyle IN_CenteredLabel => Styles.Get(Keys.IN_CenteredLabel, EditorSkin.Inspector);
            public static GUIStyle IN_DropDown => Styles.Get(Keys.IN_DropDown, EditorSkin.Inspector);

            public static GUIStyle IN_EditColliderButton =>
                Styles.Get(Keys.IN_EditColliderButton, EditorSkin.Inspector);

            public static GUIStyle IN_Foldout => Styles.Get(Keys.IN_Foldout, EditorSkin.Inspector);
            public static GUIStyle IN_Footer => Styles.Get(Keys.IN_Footer, EditorSkin.Inspector);
            public static GUIStyle IN_Label => Styles.Get(Keys.IN_Label, EditorSkin.Inspector);
            public static GUIStyle IN_LockButton => Styles.Get(Keys.IN_LockButton, EditorSkin.Inspector);

            public static GUIStyle IN_MinMaxStateDropDown =>
                Styles.Get(Keys.IN_MinMaxStateDropDown, EditorSkin.Inspector);

            public static GUIStyle IN_ObjectField => Styles.Get(Keys.IN_ObjectField, EditorSkin.Inspector);
            public static GUIStyle IN_TextField => Styles.Get(Keys.IN_TextField, EditorSkin.Inspector);

            public static GUIStyle IN_ThumbnailSelection =>
                Styles.Get(Keys.IN_ThumbnailSelection, EditorSkin.Inspector);

            public static GUIStyle IN_ThumbnailShadow => Styles.Get(Keys.IN_ThumbnailShadow, EditorSkin.Inspector);
            public static GUIStyle IN_Title => Styles.Get(Keys.IN_Title, EditorSkin.Inspector);
            public static GUIStyle IN_Title_Flat => Styles.Get(Keys.IN_Title_Flat, EditorSkin.Inspector);
            public static GUIStyle IN_TitleText => Styles.Get(Keys.IN_TitleText, EditorSkin.Inspector);
            public static GUIStyle IN_TypeSelection => Styles.Get(Keys.IN_TypeSelection, EditorSkin.Inspector);
            public static GUIStyle InnerShadowBg => Styles.Get(Keys.InnerShadowBg, EditorSkin.Inspector);
            public static GUIStyle InsertionMarker => Styles.Get(Keys.InsertionMarker, EditorSkin.Inspector);
            public static GUIStyle InvisibleButton => Styles.Get(Keys.InvisibleButton, EditorSkin.Inspector);
            public static GUIStyle LargeBoldLabel => Styles.Get(Keys.LargeBoldLabel, EditorSkin.Inspector);
            public static GUIStyle LargeButton => Styles.Get(Keys.LargeButton, EditorSkin.Inspector);
            public static GUIStyle LargeButtonLeft => Styles.Get(Keys.LargeButtonLeft, EditorSkin.Inspector);
            public static GUIStyle LargeButtonMid => Styles.Get(Keys.LargeButtonMid, EditorSkin.Inspector);
            public static GUIStyle LargeButtonRight => Styles.Get(Keys.LargeButtonRight, EditorSkin.Inspector);
            public static GUIStyle LargeLabel => Styles.Get(Keys.LargeLabel, EditorSkin.Inspector);

            public static GUIStyle LightmapEditorSelectedHighlight =>
                Styles.Get(Keys.LightmapEditorSelectedHighlight, EditorSkin.Inspector);

            public static GUIStyle LinkLabel => Styles.Get(Keys.LinkLabel, EditorSkin.Inspector);
            public static GUIStyle LODBlackBox => Styles.Get(Keys.LODBlackBox, EditorSkin.Inspector);
            public static GUIStyle LODCameraLine => Styles.Get(Keys.LODCameraLine, EditorSkin.Inspector);
            public static GUIStyle LODLevelNotifyText => Styles.Get(Keys.LODLevelNotifyText, EditorSkin.Inspector);
            public static GUIStyle LODRendererAddButton => Styles.Get(Keys.LODRendererAddButton, EditorSkin.Inspector);
            public static GUIStyle LODRendererButton => Styles.Get(Keys.LODRendererButton, EditorSkin.Inspector);
            public static GUIStyle LODRendererRemove => Styles.Get(Keys.LODRendererRemove, EditorSkin.Inspector);
            public static GUIStyle LODRenderersText => Styles.Get(Keys.LODRenderersText, EditorSkin.Inspector);
            public static GUIStyle LODSceneText => Styles.Get(Keys.LODSceneText, EditorSkin.Inspector);
            public static GUIStyle LODSliderBG => Styles.Get(Keys.LODSliderBG, EditorSkin.Inspector);
            public static GUIStyle LODSliderRange => Styles.Get(Keys.LODSliderRange, EditorSkin.Inspector);

            public static GUIStyle LODSliderRangeSelected =>
                Styles.Get(Keys.LODSliderRangeSelected, EditorSkin.Inspector);

            public static GUIStyle LODSliderText => Styles.Get(Keys.LODSliderText, EditorSkin.Inspector);

            public static GUIStyle LODSliderTextSelected =>
                Styles.Get(Keys.LODSliderTextSelected, EditorSkin.Inspector);

            public static GUIStyle MeBlendBackground => Styles.Get(Keys.MeBlendBackground, EditorSkin.Inspector);
            public static GUIStyle MeBlendPosition => Styles.Get(Keys.MeBlendPosition, EditorSkin.Inspector);
            public static GUIStyle MeBlendTriangleLeft => Styles.Get(Keys.MeBlendTriangleLeft, EditorSkin.Inspector);
            public static GUIStyle MeBlendTriangleRight => Styles.Get(Keys.MeBlendTriangleRight, EditorSkin.Inspector);
            public static GUIStyle MeLivePlayBackground => Styles.Get(Keys.MeLivePlayBackground, EditorSkin.Inspector);
            public static GUIStyle MeLivePlayBar => Styles.Get(Keys.MeLivePlayBar, EditorSkin.Inspector);
            public static GUIStyle MenuItem => Styles.Get(Keys.MenuItem, EditorSkin.Inspector);
            public static GUIStyle MenuItemMixed => Styles.Get(Keys.MenuItemMixed, EditorSkin.Inspector);
            public static GUIStyle MenuToggleItem => Styles.Get(Keys.MenuToggleItem, EditorSkin.Inspector);
            public static GUIStyle MeTimeBlockLeft => Styles.Get(Keys.MeTimeBlockLeft, EditorSkin.Inspector);
            public static GUIStyle MeTimeBlockRight => Styles.Get(Keys.MeTimeBlockRight, EditorSkin.Inspector);
            public static GUIStyle MeTimeLabel => Styles.Get(Keys.MeTimeLabel, EditorSkin.Inspector);
            public static GUIStyle MeTransitionBack => Styles.Get(Keys.MeTransitionBack, EditorSkin.Inspector);
            public static GUIStyle MeTransitionBlock => Styles.Get(Keys.MeTransitionBlock, EditorSkin.Inspector);

            public static GUIStyle MeTransitionHandleLeft =>
                Styles.Get(Keys.MeTransitionHandleLeft, EditorSkin.Inspector);

            public static GUIStyle MeTransitionHandleLeftPrev =>
                Styles.Get(Keys.MeTransitionHandleLeftPrev, EditorSkin.Inspector);

            public static GUIStyle MeTransitionHandleRight =>
                Styles.Get(Keys.MeTransitionHandleRight, EditorSkin.Inspector);

            public static GUIStyle MeTransitionHead => Styles.Get(Keys.MeTransitionHead, EditorSkin.Inspector);
            public static GUIStyle MeTransitionSelect => Styles.Get(Keys.MeTransitionSelect, EditorSkin.Inspector);

            public static GUIStyle MeTransitionSelectHead =>
                Styles.Get(Keys.MeTransitionSelectHead, EditorSkin.Inspector);

            public static GUIStyle MeTransOff2On => Styles.Get(Keys.MeTransOff2On, EditorSkin.Inspector);
            public static GUIStyle MeTransOffLeft => Styles.Get(Keys.MeTransOffLeft, EditorSkin.Inspector);
            public static GUIStyle MeTransOffRight => Styles.Get(Keys.MeTransOffRight, EditorSkin.Inspector);
            public static GUIStyle MeTransOn2Off => Styles.Get(Keys.MeTransOn2Off, EditorSkin.Inspector);
            public static GUIStyle MeTransOnLeft => Styles.Get(Keys.MeTransOnLeft, EditorSkin.Inspector);
            public static GUIStyle MeTransOnRight => Styles.Get(Keys.MeTransOnRight, EditorSkin.Inspector);
            public static GUIStyle MeTransPlayhead => Styles.Get(Keys.MeTransPlayhead, EditorSkin.Inspector);
            public static GUIStyle MiniBoldLabel => Styles.Get(Keys.MiniBoldLabel, EditorSkin.Inspector);
            public static GUIStyle minibutton => Styles.Get(Keys.minibutton, EditorSkin.Inspector);
            public static GUIStyle minibuttonleft => Styles.Get(Keys.minibuttonleft, EditorSkin.Inspector);
            public static GUIStyle minibuttonmid => Styles.Get(Keys.minibuttonmid, EditorSkin.Inspector);
            public static GUIStyle minibuttonright => Styles.Get(Keys.minibuttonright, EditorSkin.Inspector);
            public static GUIStyle MiniLabel => Styles.Get(Keys.MiniLabel, EditorSkin.Inspector);

            public static GUIStyle MiniMinMaxSliderHorizontal =>
                Styles.Get(Keys.MiniMinMaxSliderHorizontal, EditorSkin.Inspector);

            public static GUIStyle MiniMinMaxSliderVertical =>
                Styles.Get(Keys.MiniMinMaxSliderVertical, EditorSkin.Inspector);

            public static GUIStyle MiniPopup => Styles.Get(Keys.MiniPopup, EditorSkin.Inspector);
            public static GUIStyle MiniPullDown => Styles.Get(Keys.MiniPullDown, EditorSkin.Inspector);
            public static GUIStyle MiniSliderHorizontal => Styles.Get(Keys.MiniSliderHorizontal, EditorSkin.Inspector);
            public static GUIStyle MiniSliderVertical => Styles.Get(Keys.MiniSliderVertical, EditorSkin.Inspector);
            public static GUIStyle MiniTextField => Styles.Get(Keys.MiniTextField, EditorSkin.Inspector);
            public static GUIStyle MiniToolbarButton => Styles.Get(Keys.MiniToolbarButton, EditorSkin.Inspector);

            public static GUIStyle MiniToolbarButtonLeft =>
                Styles.Get(Keys.MiniToolbarButtonLeft, EditorSkin.Inspector);

            public static GUIStyle MinMaxHorizontalSliderThumb =>
                Styles.Get(Keys.MinMaxHorizontalSliderThumb, EditorSkin.Inspector);

            public static GUIStyle MultiColumnArrow => Styles.Get(Keys.MultiColumnArrow, EditorSkin.Inspector);
            public static GUIStyle MultiColumnHeader => Styles.Get(Keys.MultiColumnHeader, EditorSkin.Inspector);

            public static GUIStyle MultiColumnHeaderCenter =>
                Styles.Get(Keys.MultiColumnHeaderCenter, EditorSkin.Inspector);

            public static GUIStyle MultiColumnHeaderRight =>
                Styles.Get(Keys.MultiColumnHeaderRight, EditorSkin.Inspector);

            public static GUIStyle MultiColumnTopBar => Styles.Get(Keys.MultiColumnTopBar, EditorSkin.Inspector);
            public static GUIStyle MuteToggle => Styles.Get(Keys.MuteToggle, EditorSkin.Inspector);

            public static GUIStyle NotificationBackground =>
                Styles.Get(Keys.NotificationBackground, EditorSkin.Inspector);

            public static GUIStyle NotificationText => Styles.Get(Keys.NotificationText, EditorSkin.Inspector);
            public static GUIStyle ObjectField => Styles.Get(Keys.ObjectField, EditorSkin.Inspector);
            public static GUIStyle ObjectFieldButton => Styles.Get(Keys.ObjectFieldButton, EditorSkin.Inspector);
            public static GUIStyle ObjectFieldMiniThumb => Styles.Get(Keys.ObjectFieldMiniThumb, EditorSkin.Inspector);
            public static GUIStyle ObjectFieldThumb => Styles.Get(Keys.ObjectFieldThumb, EditorSkin.Inspector);

            public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay =>
                Styles.Get(Keys.ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Inspector);

            public static GUIStyle ObjectFieldThumbOverlay =>
                Styles.Get(Keys.ObjectFieldThumbOverlay, EditorSkin.Inspector);

            public static GUIStyle ObjectFieldThumbOverlay2 =>
                Styles.Get(Keys.ObjectFieldThumbOverlay2, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerBackground =>
                Styles.Get(Keys.ObjectPickerBackground, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerLargeStatus =>
                Styles.Get(Keys.ObjectPickerLargeStatus, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerPreviewBackground =>
                Styles.Get(Keys.ObjectPickerPreviewBackground, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerResultsEven =>
                Styles.Get(Keys.ObjectPickerResultsEven, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerResultsGrid =>
                Styles.Get(Keys.ObjectPickerResultsGrid, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerResultsOdd =>
                Styles.Get(Keys.ObjectPickerResultsOdd, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerSmallStatus =>
                Styles.Get(Keys.ObjectPickerSmallStatus, EditorSkin.Inspector);

            public static GUIStyle ObjectPickerTab => Styles.Get(Keys.ObjectPickerTab, EditorSkin.Inspector);
            public static GUIStyle ObjectPickerToolbar => Styles.Get(Keys.ObjectPickerToolbar, EditorSkin.Inspector);
            public static GUIStyle OffsetDropDown => Styles.Get(Keys.OffsetDropDown, EditorSkin.Inspector);
            public static GUIStyle OL_box => Styles.Get(Keys.OL_box, EditorSkin.Inspector);
            public static GUIStyle OL_box_flat => Styles.Get(Keys.OL_box_flat, EditorSkin.Inspector);
            public static GUIStyle OL_box_NoExpand => Styles.Get(Keys.OL_box_NoExpand, EditorSkin.Inspector);
            public static GUIStyle OL_EntryBackEven => Styles.Get(Keys.OL_EntryBackEven, EditorSkin.Inspector);
            public static GUIStyle OL_EntryBackOdd => Styles.Get(Keys.OL_EntryBackOdd, EditorSkin.Inspector);
            public static GUIStyle OL_Label => Styles.Get(Keys.OL_Label, EditorSkin.Inspector);
            public static GUIStyle OL_MiniPing => Styles.Get(Keys.OL_MiniPing, EditorSkin.Inspector);
            public static GUIStyle OL_MiniRenameField => Styles.Get(Keys.OL_MiniRenameField, EditorSkin.Inspector);
            public static GUIStyle OL_Minus => Styles.Get(Keys.OL_Minus, EditorSkin.Inspector);
            public static GUIStyle OL_Ping => Styles.Get(Keys.OL_Ping, EditorSkin.Inspector);
            public static GUIStyle OL_Plus => Styles.Get(Keys.OL_Plus, EditorSkin.Inspector);
            public static GUIStyle OL_ResultFocusMarker => Styles.Get(Keys.OL_ResultFocusMarker, EditorSkin.Inspector);
            public static GUIStyle OL_ResultLabel => Styles.Get(Keys.OL_ResultLabel, EditorSkin.Inspector);
            public static GUIStyle OL_RightLabel => Styles.Get(Keys.OL_RightLabel, EditorSkin.Inspector);
            public static GUIStyle OL_SelectedRow => Styles.Get(Keys.OL_SelectedRow, EditorSkin.Inspector);
            public static GUIStyle OL_Title => Styles.Get(Keys.OL_Title, EditorSkin.Inspector);
            public static GUIStyle OL_Title_TextRight => Styles.Get(Keys.OL_Title_TextRight, EditorSkin.Inspector);
            public static GUIStyle OL_Toggle => Styles.Get(Keys.OL_Toggle, EditorSkin.Inspector);
            public static GUIStyle OL_ToggleMixed => Styles.Get(Keys.OL_ToggleMixed, EditorSkin.Inspector);
            public static GUIStyle OL_ToggleWhite => Styles.Get(Keys.OL_ToggleWhite, EditorSkin.Inspector);
            public static GUIStyle OT_BottomBar => Styles.Get(Keys.OT_BottomBar, EditorSkin.Inspector);
            public static GUIStyle OT_TopBar => Styles.Get(Keys.OT_TopBar, EditorSkin.Inspector);
            public static GUIStyle OverrideMargin => Styles.Get(Keys.OverrideMargin, EditorSkin.Inspector);
            public static GUIStyle PaneOptions => Styles.Get(Keys.PaneOptions, EditorSkin.Inspector);
            public static GUIStyle PlayerSettingsLevel => Styles.Get(Keys.PlayerSettingsLevel, EditorSkin.Inspector);

            public static GUIStyle PlayerSettingsPlatform =>
                Styles.Get(Keys.PlayerSettingsPlatform, EditorSkin.Inspector);

            public static GUIStyle Popup => Styles.Get(Keys.Popup, EditorSkin.Inspector);
            public static GUIStyle PopupCurveDropdown => Styles.Get(Keys.PopupCurveDropdown, EditorSkin.Inspector);

            public static GUIStyle PopupCurveEditorBackground =>
                Styles.Get(Keys.PopupCurveEditorBackground, EditorSkin.Inspector);

            public static GUIStyle PopupCurveEditorSwatch =>
                Styles.Get(Keys.PopupCurveEditorSwatch, EditorSkin.Inspector);

            public static GUIStyle PopupCurveSwatchBackground =>
                Styles.Get(Keys.PopupCurveSwatchBackground, EditorSkin.Inspector);

            public static GUIStyle PR_BrokenPrefabLabel => Styles.Get(Keys.PR_BrokenPrefabLabel, EditorSkin.Inspector);

            public static GUIStyle PR_DisabledBrokenPrefabLabel =>
                Styles.Get(Keys.PR_DisabledBrokenPrefabLabel, EditorSkin.Inspector);

            public static GUIStyle PR_DisabledLabel => Styles.Get(Keys.PR_DisabledLabel, EditorSkin.Inspector);

            public static GUIStyle PR_DisabledPrefabLabel =>
                Styles.Get(Keys.PR_DisabledPrefabLabel, EditorSkin.Inspector);

            public static GUIStyle PR_Insertion => Styles.Get(Keys.PR_Insertion, EditorSkin.Inspector);
            public static GUIStyle PR_Label => Styles.Get(Keys.PR_Label, EditorSkin.Inspector);
            public static GUIStyle PR_Ping => Styles.Get(Keys.PR_Ping, EditorSkin.Inspector);
            public static GUIStyle PR_PrefabLabel => Styles.Get(Keys.PR_PrefabLabel, EditorSkin.Inspector);
            public static GUIStyle PR_TextField => Styles.Get(Keys.PR_TextField, EditorSkin.Inspector);
            public static GUIStyle PreBackground => Styles.Get(Keys.PreBackground, EditorSkin.Inspector);
            public static GUIStyle PreBackgroundSolid => Styles.Get(Keys.PreBackgroundSolid, EditorSkin.Inspector);
            public static GUIStyle PreButton => Styles.Get(Keys.PreButton, EditorSkin.Inspector);
            public static GUIStyle PreButtonBlue => Styles.Get(Keys.PreButtonBlue, EditorSkin.Inspector);
            public static GUIStyle PreButtonGreen => Styles.Get(Keys.PreButtonGreen, EditorSkin.Inspector);
            public static GUIStyle PreButtonRed => Styles.Get(Keys.PreButtonRed, EditorSkin.Inspector);
            public static GUIStyle PreDropDown => Styles.Get(Keys.PreDropDown, EditorSkin.Inspector);

            public static GUIStyle PreferencesKeysElement =>
                Styles.Get(Keys.PreferencesKeysElement, EditorSkin.Inspector);

            public static GUIStyle PreferencesSection => Styles.Get(Keys.PreferencesSection, EditorSkin.Inspector);

            public static GUIStyle PreferencesSectionBox =>
                Styles.Get(Keys.PreferencesSectionBox, EditorSkin.Inspector);

            public static GUIStyle PrefixLabel => Styles.Get(Keys.PrefixLabel, EditorSkin.Inspector);

            public static GUIStyle PreHorizontalScrollbar =>
                Styles.Get(Keys.PreHorizontalScrollbar, EditorSkin.Inspector);

            public static GUIStyle PreHorizontalScrollbarThumb =>
                Styles.Get(Keys.PreHorizontalScrollbarThumb, EditorSkin.Inspector);

            public static GUIStyle PreLabel => Styles.Get(Keys.PreLabel, EditorSkin.Inspector);
            public static GUIStyle PreLabelUpper => Styles.Get(Keys.PreLabelUpper, EditorSkin.Inspector);
            public static GUIStyle PreMiniLabel => Styles.Get(Keys.PreMiniLabel, EditorSkin.Inspector);
            public static GUIStyle PreOverlayLabel => Styles.Get(Keys.PreOverlayLabel, EditorSkin.Inspector);
            public static GUIStyle PreSlider => Styles.Get(Keys.PreSlider, EditorSkin.Inspector);
            public static GUIStyle PreSliderThumb => Styles.Get(Keys.PreSliderThumb, EditorSkin.Inspector);
            public static GUIStyle PreToolbar => Styles.Get(Keys.PreToolbar, EditorSkin.Inspector);
            public static GUIStyle PreToolbar2 => Styles.Get(Keys.PreToolbar2, EditorSkin.Inspector);
            public static GUIStyle PreVerticalScrollbar => Styles.Get(Keys.PreVerticalScrollbar, EditorSkin.Inspector);

            public static GUIStyle PreVerticalScrollbarThumb =>
                Styles.Get(Keys.PreVerticalScrollbarThumb, EditorSkin.Inspector);

            public static GUIStyle PreviewPackageInUse => Styles.Get(Keys.PreviewPackageInUse, EditorSkin.Inspector);
            public static GUIStyle ProfilerBadge => Styles.Get(Keys.ProfilerBadge, EditorSkin.Inspector);

            public static GUIStyle ProfilerDetailViewBackground =>
                Styles.Get(Keys.ProfilerDetailViewBackground, EditorSkin.Inspector);

            public static GUIStyle ProfilerGraphBackground =>
                Styles.Get(Keys.ProfilerGraphBackground, EditorSkin.Inspector);

            public static GUIStyle ProfilerHeaderLabel => Styles.Get(Keys.ProfilerHeaderLabel, EditorSkin.Inspector);
            public static GUIStyle ProfilerLeftPane => Styles.Get(Keys.ProfilerLeftPane, EditorSkin.Inspector);

            public static GUIStyle ProfilerNoDataAvailable =>
                Styles.Get(Keys.ProfilerNoDataAvailable, EditorSkin.Inspector);

            public static GUIStyle ProfilerNotSupportedWarningLabel =>
                Styles.Get(Keys.ProfilerNotSupportedWarningLabel, EditorSkin.Inspector);

            public static GUIStyle ProfilerPaneSubLabel => Styles.Get(Keys.ProfilerPaneSubLabel, EditorSkin.Inspector);
            public static GUIStyle ProfilerRightPane => Styles.Get(Keys.ProfilerRightPane, EditorSkin.Inspector);

            public static GUIStyle ProfilerScrollviewBackground =>
                Styles.Get(Keys.ProfilerScrollviewBackground, EditorSkin.Inspector);

            public static GUIStyle ProfilerSelectedLabel =>
                Styles.Get(Keys.ProfilerSelectedLabel, EditorSkin.Inspector);

            public static GUIStyle ProfilerTimelineBar => Styles.Get(Keys.ProfilerTimelineBar, EditorSkin.Inspector);

            public static GUIStyle ProfilerTimelineDigDownArrow =>
                Styles.Get(Keys.ProfilerTimelineDigDownArrow, EditorSkin.Inspector);

            public static GUIStyle ProfilerTimelineFoldout =>
                Styles.Get(Keys.ProfilerTimelineFoldout, EditorSkin.Inspector);

            public static GUIStyle ProfilerTimelineLeftPane =>
                Styles.Get(Keys.ProfilerTimelineLeftPane, EditorSkin.Inspector);

            public static GUIStyle ProfilerTimelineRollUpArrow =>
                Styles.Get(Keys.ProfilerTimelineRollUpArrow, EditorSkin.Inspector);

            public static GUIStyle ProgressBarBack => Styles.Get(Keys.ProgressBarBack, EditorSkin.Inspector);
            public static GUIStyle ProgressBarBar => Styles.Get(Keys.ProgressBarBar, EditorSkin.Inspector);
            public static GUIStyle ProgressBarText => Styles.Get(Keys.ProgressBarText, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserBottomBarBg =>
                Styles.Get(Keys.ProjectBrowserBottomBarBg, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserGridLabel =>
                Styles.Get(Keys.ProjectBrowserGridLabel, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserHeaderBgMiddle =>
                Styles.Get(Keys.ProjectBrowserHeaderBgMiddle, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserHeaderBgTop =>
                Styles.Get(Keys.ProjectBrowserHeaderBgTop, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserIconAreaBg =>
                Styles.Get(Keys.ProjectBrowserIconAreaBg, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserIconDropShadow, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserPreviewBg =>
                Styles.Get(Keys.ProjectBrowserPreviewBg, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetBg =>
                Styles.Get(Keys.ProjectBrowserSubAssetBg, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetBgCloseEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetBgDivider =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgDivider, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetBgMiddle =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgMiddle, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetBgOpenEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetExpandBtn =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtn, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserTextureIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserTextureIconDropShadow, EditorSkin.Inspector);

            public static GUIStyle ProjectBrowserTopBarBg =>
                Styles.Get(Keys.ProjectBrowserTopBarBg, EditorSkin.Inspector);

            public static GUIStyle QualitySettingsDefault =>
                Styles.Get(Keys.QualitySettingsDefault, EditorSkin.Inspector);

            public static GUIStyle quick_search_tab => Styles.Get(Keys.quick_search_tab, EditorSkin.Inspector);
            public static GUIStyle Radio => Styles.Get(Keys.Radio, EditorSkin.Inspector);
            public static GUIStyle RectangleToolHBar => Styles.Get(Keys.RectangleToolHBar, EditorSkin.Inspector);

            public static GUIStyle RectangleToolHBarLeft =>
                Styles.Get(Keys.RectangleToolHBarLeft, EditorSkin.Inspector);

            public static GUIStyle RectangleToolHBarRight =>
                Styles.Get(Keys.RectangleToolHBarRight, EditorSkin.Inspector);

            public static GUIStyle RectangleToolHighlight =>
                Styles.Get(Keys.RectangleToolHighlight, EditorSkin.Inspector);

            public static GUIStyle RectangleToolRippleLeft =>
                Styles.Get(Keys.RectangleToolRippleLeft, EditorSkin.Inspector);

            public static GUIStyle RectangleToolRippleRight =>
                Styles.Get(Keys.RectangleToolRippleRight, EditorSkin.Inspector);

            public static GUIStyle RectangleToolScaleBottom =>
                Styles.Get(Keys.RectangleToolScaleBottom, EditorSkin.Inspector);

            public static GUIStyle RectangleToolScaleLeft =>
                Styles.Get(Keys.RectangleToolScaleLeft, EditorSkin.Inspector);

            public static GUIStyle RectangleToolScaleRight =>
                Styles.Get(Keys.RectangleToolScaleRight, EditorSkin.Inspector);

            public static GUIStyle RectangleToolScaleTop =>
                Styles.Get(Keys.RectangleToolScaleTop, EditorSkin.Inspector);

            public static GUIStyle RectangleToolSelection =>
                Styles.Get(Keys.RectangleToolSelection, EditorSkin.Inspector);

            public static GUIStyle RectangleToolVBar => Styles.Get(Keys.RectangleToolVBar, EditorSkin.Inspector);

            public static GUIStyle RectangleToolVBarBottom =>
                Styles.Get(Keys.RectangleToolVBarBottom, EditorSkin.Inspector);

            public static GUIStyle RectangleToolVBarTop => Styles.Get(Keys.RectangleToolVBarTop, EditorSkin.Inspector);
            public static GUIStyle RegionBg => Styles.Get(Keys.RegionBg, EditorSkin.Inspector);
            public static GUIStyle ReorderableList => Styles.Get(Keys.ReorderableList, EditorSkin.Inspector);

            public static GUIStyle ReorderableListRightAligned =>
                Styles.Get(Keys.ReorderableListRightAligned, EditorSkin.Inspector);

            public static GUIStyle RightAlignedLabel => Styles.Get(Keys.RightAlignedLabel, EditorSkin.Inspector);
            public static GUIStyle RightLabel => Styles.Get(Keys.RightLabel, EditorSkin.Inspector);
            public static GUIStyle RL_Background => Styles.Get(Keys.RL_Background, EditorSkin.Inspector);
            public static GUIStyle RL_DragHandle => Styles.Get(Keys.RL_DragHandle, EditorSkin.Inspector);
            public static GUIStyle RL_Element => Styles.Get(Keys.RL_Element, EditorSkin.Inspector);
            public static GUIStyle RL_Empty_Header => Styles.Get(Keys.RL_Empty_Header, EditorSkin.Inspector);
            public static GUIStyle RL_Footer => Styles.Get(Keys.RL_Footer, EditorSkin.Inspector);
            public static GUIStyle RL_FooterButton => Styles.Get(Keys.RL_FooterButton, EditorSkin.Inspector);
            public static GUIStyle RL_Header => Styles.Get(Keys.RL_Header, EditorSkin.Inspector);
            public static GUIStyle SC_ViewAxisLabel => Styles.Get(Keys.SC_ViewAxisLabel, EditorSkin.Inspector);
            public static GUIStyle SC_ViewLabel => Styles.Get(Keys.SC_ViewLabel, EditorSkin.Inspector);
            public static GUIStyle SC_ViewLabelCentered => Styles.Get(Keys.SC_ViewLabelCentered, EditorSkin.Inspector);

            public static GUIStyle SC_ViewLabelLeftAligned =>
                Styles.Get(Keys.SC_ViewLabelLeftAligned, EditorSkin.Inspector);

            public static GUIStyle SceneTopBarBg => Styles.Get(Keys.SceneTopBarBg, EditorSkin.Inspector);

            public static GUIStyle SceneViewOverlayTransparentBackground =>
                Styles.Get(Keys.SceneViewOverlayTransparentBackground, EditorSkin.Inspector);

            public static GUIStyle SceneVisibility => Styles.Get(Keys.SceneVisibility, EditorSkin.Inspector);
            public static GUIStyle ScriptText => Styles.Get(Keys.ScriptText, EditorSkin.Inspector);
            public static GUIStyle ScrollViewAlt => Styles.Get(Keys.ScrollViewAlt, EditorSkin.Inspector);
            public static GUIStyle SearchCancelButton => Styles.Get(Keys.SearchCancelButton, EditorSkin.Inspector);

            public static GUIStyle SearchCancelButtonEmpty =>
                Styles.Get(Keys.SearchCancelButtonEmpty, EditorSkin.Inspector);

            public static GUIStyle SearchModeFilter => Styles.Get(Keys.SearchModeFilter, EditorSkin.Inspector);
            public static GUIStyle SearchTextField => Styles.Get(Keys.SearchTextField, EditorSkin.Inspector);
            public static GUIStyle SelectionRect => Styles.Get(Keys.SelectionRect, EditorSkin.Inspector);
            public static GUIStyle SettingsHeader => Styles.Get(Keys.SettingsHeader, EditorSkin.Inspector);
            public static GUIStyle SettingsIconButton => Styles.Get(Keys.SettingsIconButton, EditorSkin.Inspector);
            public static GUIStyle SettingsListItem => Styles.Get(Keys.SettingsListItem, EditorSkin.Inspector);
            public static GUIStyle SettingsTreeItem => Styles.Get(Keys.SettingsTreeItem, EditorSkin.Inspector);
            public static GUIStyle ShurikenCheckMark => Styles.Get(Keys.ShurikenCheckMark, EditorSkin.Inspector);

            public static GUIStyle ShurikenCheckMarkMixed =>
                Styles.Get(Keys.ShurikenCheckMarkMixed, EditorSkin.Inspector);

            public static GUIStyle ShurikenDropdown => Styles.Get(Keys.ShurikenDropdown, EditorSkin.Inspector);

            public static GUIStyle ShurikenEditableLabel =>
                Styles.Get(Keys.ShurikenEditableLabel, EditorSkin.Inspector);

            public static GUIStyle ShurikenEffectBg => Styles.Get(Keys.ShurikenEffectBg, EditorSkin.Inspector);
            public static GUIStyle ShurikenEmitterTitle => Styles.Get(Keys.ShurikenEmitterTitle, EditorSkin.Inspector);
            public static GUIStyle ShurikenLabel => Styles.Get(Keys.ShurikenLabel, EditorSkin.Inspector);
            public static GUIStyle ShurikenMinus => Styles.Get(Keys.ShurikenMinus, EditorSkin.Inspector);
            public static GUIStyle ShurikenModuleBg => Styles.Get(Keys.ShurikenModuleBg, EditorSkin.Inspector);
            public static GUIStyle ShurikenModuleTitle => Styles.Get(Keys.ShurikenModuleTitle, EditorSkin.Inspector);
            public static GUIStyle ShurikenObjectField => Styles.Get(Keys.ShurikenObjectField, EditorSkin.Inspector);
            public static GUIStyle ShurikenPlus => Styles.Get(Keys.ShurikenPlus, EditorSkin.Inspector);
            public static GUIStyle ShurikenPopup => Styles.Get(Keys.ShurikenPopup, EditorSkin.Inspector);
            public static GUIStyle ShurikenToggle => Styles.Get(Keys.ShurikenToggle, EditorSkin.Inspector);
            public static GUIStyle ShurikenToggleMixed => Styles.Get(Keys.ShurikenToggleMixed, EditorSkin.Inspector);
            public static GUIStyle ShurikenValue => Styles.Get(Keys.ShurikenValue, EditorSkin.Inspector);
            public static GUIStyle SliderMixed => Styles.Get(Keys.SliderMixed, EditorSkin.Inspector);
            public static GUIStyle SoloToggle => Styles.Get(Keys.SoloToggle, EditorSkin.Inspector);
            public static GUIStyle StaticDropdown => Styles.Get(Keys.StaticDropdown, EditorSkin.Inspector);
            public static GUIStyle StatusBarIcon => Styles.Get(Keys.StatusBarIcon, EditorSkin.Inspector);
            public static GUIStyle sv_iconselector_back => Styles.Get(Keys.sv_iconselector_back, EditorSkin.Inspector);

            public static GUIStyle sv_iconselector_button =>
                Styles.Get(Keys.sv_iconselector_button, EditorSkin.Inspector);

            public static GUIStyle sv_iconselector_labelselection =>
                Styles.Get(Keys.sv_iconselector_labelselection, EditorSkin.Inspector);

            public static GUIStyle sv_iconselector_selection =>
                Styles.Get(Keys.sv_iconselector_selection, EditorSkin.Inspector);

            public static GUIStyle sv_iconselector_sep => Styles.Get(Keys.sv_iconselector_sep, EditorSkin.Inspector);
            public static GUIStyle sv_label_0 => Styles.Get(Keys.sv_label_0, EditorSkin.Inspector);
            public static GUIStyle sv_label_1 => Styles.Get(Keys.sv_label_1, EditorSkin.Inspector);
            public static GUIStyle sv_label_2 => Styles.Get(Keys.sv_label_2, EditorSkin.Inspector);
            public static GUIStyle sv_label_3 => Styles.Get(Keys.sv_label_3, EditorSkin.Inspector);
            public static GUIStyle sv_label_4 => Styles.Get(Keys.sv_label_4, EditorSkin.Inspector);
            public static GUIStyle sv_label_5 => Styles.Get(Keys.sv_label_5, EditorSkin.Inspector);
            public static GUIStyle sv_label_6 => Styles.Get(Keys.sv_label_6, EditorSkin.Inspector);
            public static GUIStyle sv_label_7 => Styles.Get(Keys.sv_label_7, EditorSkin.Inspector);
            public static GUIStyle Tab_first => Styles.Get(Keys.Tab_first, EditorSkin.Inspector);
            public static GUIStyle Tab_last => Styles.Get(Keys.Tab_last, EditorSkin.Inspector);
            public static GUIStyle Tab_middle => Styles.Get(Keys.Tab_middle, EditorSkin.Inspector);
            public static GUIStyle Tab_onlyOne => Styles.Get(Keys.Tab_onlyOne, EditorSkin.Inspector);
            public static GUIStyle TabWindowBackground => Styles.Get(Keys.TabWindowBackground, EditorSkin.Inspector);
            public static GUIStyle Tag_MenuItem => Styles.Get(Keys.Tag_MenuItem, EditorSkin.Inspector);
            public static GUIStyle TE_BoxBackground => Styles.Get(Keys.TE_BoxBackground, EditorSkin.Inspector);
            public static GUIStyle TE_DefaultTime => Styles.Get(Keys.TE_DefaultTime, EditorSkin.Inspector);
            public static GUIStyle TE_DropField => Styles.Get(Keys.TE_DropField, EditorSkin.Inspector);
            public static GUIStyle TE_ElementBackground => Styles.Get(Keys.TE_ElementBackground, EditorSkin.Inspector);
            public static GUIStyle TE_NodeBackground => Styles.Get(Keys.TE_NodeBackground, EditorSkin.Inspector);
            public static GUIStyle TE_NodeBox => Styles.Get(Keys.TE_NodeBox, EditorSkin.Inspector);
            public static GUIStyle TE_NodeBoxSelected => Styles.Get(Keys.TE_NodeBoxSelected, EditorSkin.Inspector);
            public static GUIStyle TE_NodeLabelBot => Styles.Get(Keys.TE_NodeLabelBot, EditorSkin.Inspector);
            public static GUIStyle TE_NodeLabelTop => Styles.Get(Keys.TE_NodeLabelTop, EditorSkin.Inspector);
            public static GUIStyle TE_PinLabel => Styles.Get(Keys.TE_PinLabel, EditorSkin.Inspector);
            public static GUIStyle TE_Toolbar => Styles.Get(Keys.TE_Toolbar, EditorSkin.Inspector);
            public static GUIStyle TE_toolbarbutton => Styles.Get(Keys.TE_toolbarbutton, EditorSkin.Inspector);
            public static GUIStyle TE_ToolbarDropDown => Styles.Get(Keys.TE_ToolbarDropDown, EditorSkin.Inspector);
            public static GUIStyle TextFieldDropDown => Styles.Get(Keys.TextFieldDropDown, EditorSkin.Inspector);

            public static GUIStyle TextFieldDropDownText =>
                Styles.Get(Keys.TextFieldDropDownText, EditorSkin.Inspector);

            public static GUIStyle TimeAreaToolbar => Styles.Get(Keys.TimeAreaToolbar, EditorSkin.Inspector);
            public static GUIStyle TimeRulerBackground => Styles.Get(Keys.TimeRulerBackground, EditorSkin.Inspector);
            public static GUIStyle TimeScrubber => Styles.Get(Keys.TimeScrubber, EditorSkin.Inspector);
            public static GUIStyle TimeScrubberButton => Styles.Get(Keys.TimeScrubberButton, EditorSkin.Inspector);
            public static GUIStyle Titlebar_Foldout => Styles.Get(Keys.Titlebar_Foldout, EditorSkin.Inspector);
            public static GUIStyle TL_InPoint => Styles.Get(Keys.TL_InPoint, EditorSkin.Inspector);
            public static GUIStyle TL_OutPoint => Styles.Get(Keys.TL_OutPoint, EditorSkin.Inspector);
            public static GUIStyle TL_Playhead => Styles.Get(Keys.TL_Playhead, EditorSkin.Inspector);
            public static GUIStyle ToggleMixed => Styles.Get(Keys.ToggleMixed, EditorSkin.Inspector);
            public static GUIStyle Toolbar => Styles.Get(Keys.Toolbar, EditorSkin.Inspector);
            public static GUIStyle ToolbarBoldLabel => Styles.Get(Keys.ToolbarBoldLabel, EditorSkin.Inspector);
            public static GUIStyle ToolbarBottom => Styles.Get(Keys.ToolbarBottom, EditorSkin.Inspector);
            public static GUIStyle toolbarbutton => Styles.Get(Keys.toolbarbutton, EditorSkin.Inspector);
            public static GUIStyle ToolbarButtonFlat => Styles.Get(Keys.ToolbarButtonFlat, EditorSkin.Inspector);
            public static GUIStyle toolbarbuttonLeft => Styles.Get(Keys.toolbarbuttonLeft, EditorSkin.Inspector);
            public static GUIStyle toolbarbuttonRight => Styles.Get(Keys.toolbarbuttonRight, EditorSkin.Inspector);

            public static GUIStyle ToolbarCreateAddNewDropDown =>
                Styles.Get(Keys.ToolbarCreateAddNewDropDown, EditorSkin.Inspector);

            public static GUIStyle ToolbarDropDown => Styles.Get(Keys.ToolbarDropDown, EditorSkin.Inspector);
            public static GUIStyle ToolbarDropDownLeft => Styles.Get(Keys.ToolbarDropDownLeft, EditorSkin.Inspector);
            public static GUIStyle ToolbarDropDownRight => Styles.Get(Keys.ToolbarDropDownRight, EditorSkin.Inspector);

            public static GUIStyle ToolbarDropDownToggle =>
                Styles.Get(Keys.ToolbarDropDownToggle, EditorSkin.Inspector);

            public static GUIStyle ToolbarDropDownToggleRight =>
                Styles.Get(Keys.ToolbarDropDownToggleRight, EditorSkin.Inspector);

            public static GUIStyle ToolbarLabel => Styles.Get(Keys.ToolbarLabel, EditorSkin.Inspector);
            public static GUIStyle ToolbarPopup => Styles.Get(Keys.ToolbarPopup, EditorSkin.Inspector);
            public static GUIStyle ToolbarPopupLeft => Styles.Get(Keys.ToolbarPopupLeft, EditorSkin.Inspector);
            public static GUIStyle ToolbarPopupRight => Styles.Get(Keys.ToolbarPopupRight, EditorSkin.Inspector);

            public static GUIStyle ToolbarSeachCancelButton =>
                Styles.Get(Keys.ToolbarSeachCancelButton, EditorSkin.Inspector);

            public static GUIStyle ToolbarSeachCancelButtonEmpty =>
                Styles.Get(Keys.ToolbarSeachCancelButtonEmpty, EditorSkin.Inspector);

            public static GUIStyle ToolbarSeachTextField =>
                Styles.Get(Keys.ToolbarSeachTextField, EditorSkin.Inspector);

            public static GUIStyle ToolbarSeachTextFieldPopup =>
                Styles.Get(Keys.ToolbarSeachTextFieldPopup, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchCancelButtonWithJump =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJump, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchCancelButtonWithJumpEmpty =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJumpEmpty, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchField => Styles.Get(Keys.ToolbarSearchField, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchTextFieldJumpButton =>
                Styles.Get(Keys.ToolbarSearchTextFieldJumpButton, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchTextFieldWithJump =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJump, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopup =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopup, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopupSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopupSynced, EditorSkin.Inspector);

            public static GUIStyle ToolbarSearchTextFieldWithJumpSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpSynced, EditorSkin.Inspector);

            public static GUIStyle ToolbarSlider => Styles.Get(Keys.ToolbarSlider, EditorSkin.Inspector);

            public static GUIStyle ToolbarSliderTextField =>
                Styles.Get(Keys.ToolbarSliderTextField, EditorSkin.Inspector);

            public static GUIStyle ToolbarTextField => Styles.Get(Keys.ToolbarTextField, EditorSkin.Inspector);
            public static GUIStyle Tooltip => Styles.Get(Keys.Tooltip, EditorSkin.Inspector);
            public static GUIStyle TV_Insertion => Styles.Get(Keys.TV_Insertion, EditorSkin.Inspector);
            public static GUIStyle TV_Line => Styles.Get(Keys.TV_Line, EditorSkin.Inspector);
            public static GUIStyle TV_LineBold => Styles.Get(Keys.TV_LineBold, EditorSkin.Inspector);
            public static GUIStyle TV_Ping => Styles.Get(Keys.TV_Ping, EditorSkin.Inspector);
            public static GUIStyle TV_Selection => Styles.Get(Keys.TV_Selection, EditorSkin.Inspector);
            public static GUIStyle U2D_createRect => Styles.Get(Keys.U2D_createRect, EditorSkin.Inspector);
            public static GUIStyle U2D_dragDot => Styles.Get(Keys.U2D_dragDot, EditorSkin.Inspector);
            public static GUIStyle U2D_dragDotActive => Styles.Get(Keys.U2D_dragDotActive, EditorSkin.Inspector);
            public static GUIStyle U2D_dragDotDimmed => Styles.Get(Keys.U2D_dragDotDimmed, EditorSkin.Inspector);
            public static GUIStyle U2D_pivotDot => Styles.Get(Keys.U2D_pivotDot, EditorSkin.Inspector);
            public static GUIStyle U2D_pivotDotActive => Styles.Get(Keys.U2D_pivotDotActive, EditorSkin.Inspector);

            public static GUIStyle VerticalMinMaxScrollbarThumb =>
                Styles.Get(Keys.VerticalMinMaxScrollbarThumb, EditorSkin.Inspector);

            public static GUIStyle VerticalSliderThumbExtent =>
                Styles.Get(Keys.VerticalSliderThumbExtent, EditorSkin.Inspector);

            public static GUIStyle VideoClipImporterLabel =>
                Styles.Get(Keys.VideoClipImporterLabel, EditorSkin.Inspector);

            public static GUIStyle WarningOverlay => Styles.Get(Keys.WarningOverlay, EditorSkin.Inspector);
            public static GUIStyle WhiteBackground => Styles.Get(Keys.WhiteBackground, EditorSkin.Inspector);
            public static GUIStyle WhiteBoldLabel => Styles.Get(Keys.WhiteBoldLabel, EditorSkin.Inspector);
            public static GUIStyle WhiteLabel => Styles.Get(Keys.WhiteLabel, EditorSkin.Inspector);

            public static GUIStyle WhiteLargeCenterLabel =>
                Styles.Get(Keys.WhiteLargeCenterLabel, EditorSkin.Inspector);

            public static GUIStyle WhiteLargeLabel => Styles.Get(Keys.WhiteLargeLabel, EditorSkin.Inspector);
            public static GUIStyle WhiteMiniLabel => Styles.Get(Keys.WhiteMiniLabel, EditorSkin.Inspector);
            public static GUIStyle WinBtn => Styles.Get(Keys.WinBtn, EditorSkin.Inspector);
            public static GUIStyle WinBtnClose => Styles.Get(Keys.WinBtnClose, EditorSkin.Inspector);
            public static GUIStyle WinBtnCloseMac => Styles.Get(Keys.WinBtnCloseMac, EditorSkin.Inspector);
            public static GUIStyle WinBtnInactiveMac => Styles.Get(Keys.WinBtnInactiveMac, EditorSkin.Inspector);
            public static GUIStyle WinBtnMax => Styles.Get(Keys.WinBtnMax, EditorSkin.Inspector);
            public static GUIStyle WinBtnMaxMac => Styles.Get(Keys.WinBtnMaxMac, EditorSkin.Inspector);
            public static GUIStyle WinBtnMinMac => Styles.Get(Keys.WinBtnMinMac, EditorSkin.Inspector);
            public static GUIStyle WinBtnRestore => Styles.Get(Keys.WinBtnRestore, EditorSkin.Inspector);
            public static GUIStyle WinBtnRestoreMac => Styles.Get(Keys.WinBtnRestoreMac, EditorSkin.Inspector);
            public static GUIStyle WindowBottomResize => Styles.Get(Keys.WindowBottomResize, EditorSkin.Inspector);
            public static GUIStyle Wizard_Box => Styles.Get(Keys.Wizard_Box, EditorSkin.Inspector);
            public static GUIStyle Wizard_Error => Styles.Get(Keys.Wizard_Error, EditorSkin.Inspector);
            public static GUIStyle WordWrapLabel => Styles.Get(Keys.WordWrapLabel, EditorSkin.Inspector);
            public static GUIStyle wordwrapminibutton => Styles.Get(Keys.wordwrapminibutton, EditorSkin.Inspector);
            public static GUIStyle WordWrappedLabel => Styles.Get(Keys.WordWrappedLabel, EditorSkin.Inspector);
            public static GUIStyle WordWrappedMiniLabel => Styles.Get(Keys.WordWrappedMiniLabel, EditorSkin.Inspector);
        }

        public static class Scene {
            public static GUIStyle box => Styles.Get(Keys.box, EditorSkin.Scene);
            public static GUIStyle button => Styles.Get(Keys.button, EditorSkin.Scene);
            public static GUIStyle toggle => Styles.Get(Keys.toggle, EditorSkin.Scene);
            public static GUIStyle label => Styles.Get(Keys.label, EditorSkin.Scene);
            public static GUIStyle window => Styles.Get(Keys.window, EditorSkin.Scene);
            public static GUIStyle textfield => Styles.Get(Keys.textfield, EditorSkin.Scene);
            public static GUIStyle textarea => Styles.Get(Keys.textarea, EditorSkin.Scene);
            public static GUIStyle horizontalslider => Styles.Get(Keys.horizontalslider, EditorSkin.Scene);
            public static GUIStyle horizontalsliderthumb => Styles.Get(Keys.horizontalsliderthumb, EditorSkin.Scene);
            public static GUIStyle verticalslider => Styles.Get(Keys.verticalslider, EditorSkin.Scene);
            public static GUIStyle verticalsliderthumb => Styles.Get(Keys.verticalsliderthumb, EditorSkin.Scene);
            public static GUIStyle horizontalscrollbar => Styles.Get(Keys.horizontalscrollbar, EditorSkin.Scene);

            public static GUIStyle horizontalscrollbarthumb =>
                Styles.Get(Keys.horizontalscrollbarthumb, EditorSkin.Scene);

            public static GUIStyle horizontalscrollbarleftbutton =>
                Styles.Get(Keys.horizontalscrollbarleftbutton, EditorSkin.Scene);

            public static GUIStyle horizontalscrollbarrightbutton =>
                Styles.Get(Keys.horizontalscrollbarrightbutton, EditorSkin.Scene);

            public static GUIStyle verticalscrollbar => Styles.Get(Keys.verticalscrollbar, EditorSkin.Scene);
            public static GUIStyle verticalscrollbarthumb => Styles.Get(Keys.verticalscrollbarthumb, EditorSkin.Scene);

            public static GUIStyle verticalscrollbarupbutton =>
                Styles.Get(Keys.verticalscrollbarupbutton, EditorSkin.Scene);

            public static GUIStyle verticalscrollbardownbutton =>
                Styles.Get(Keys.verticalscrollbardownbutton, EditorSkin.Scene);

            public static GUIStyle scrollview => Styles.Get(Keys.scrollview, EditorSkin.Scene);

            public static GUIStyle AboutWIndowLicenseLabel =>
                Styles.Get(Keys.AboutWIndowLicenseLabel, EditorSkin.Scene);

            public static GUIStyle AC_BoldHeader => Styles.Get(Keys.AC_BoldHeader, EditorSkin.Scene);
            public static GUIStyle AC_Button => Styles.Get(Keys.AC_Button, EditorSkin.Scene);
            public static GUIStyle AC_ComponentButton => Styles.Get(Keys.AC_ComponentButton, EditorSkin.Scene);
            public static GUIStyle AC_GroupButton => Styles.Get(Keys.AC_GroupButton, EditorSkin.Scene);
            public static GUIStyle AC_LeftArrow => Styles.Get(Keys.AC_LeftArrow, EditorSkin.Scene);
            public static GUIStyle AC_PreviewHeader => Styles.Get(Keys.AC_PreviewHeader, EditorSkin.Scene);
            public static GUIStyle AC_PreviewText => Styles.Get(Keys.AC_PreviewText, EditorSkin.Scene);
            public static GUIStyle AC_RightArrow => Styles.Get(Keys.AC_RightArrow, EditorSkin.Scene);

            public static GUIStyle AM_ChannelStripHeaderStyle =>
                Styles.Get(Keys.AM_ChannelStripHeaderStyle, EditorSkin.Scene);

            public static GUIStyle AM_EffectName => Styles.Get(Keys.AM_EffectName, EditorSkin.Scene);
            public static GUIStyle AM_HeaderStyle => Styles.Get(Keys.AM_HeaderStyle, EditorSkin.Scene);
            public static GUIStyle AM_MixerHeader => Styles.Get(Keys.AM_MixerHeader, EditorSkin.Scene);
            public static GUIStyle AM_MixerHeader2 => Styles.Get(Keys.AM_MixerHeader2, EditorSkin.Scene);
            public static GUIStyle AM_ToolbarLabel => Styles.Get(Keys.AM_ToolbarLabel, EditorSkin.Scene);
            public static GUIStyle AM_ToolbarObjectField => Styles.Get(Keys.AM_ToolbarObjectField, EditorSkin.Scene);
            public static GUIStyle AM_TotalVuLabel => Styles.Get(Keys.AM_TotalVuLabel, EditorSkin.Scene);
            public static GUIStyle AM_VuValue => Styles.Get(Keys.AM_VuValue, EditorSkin.Scene);

            public static GUIStyle AnimationEventBackground =>
                Styles.Get(Keys.AnimationEventBackground, EditorSkin.Scene);

            public static GUIStyle AnimationEventTooltip => Styles.Get(Keys.AnimationEventTooltip, EditorSkin.Scene);

            public static GUIStyle AnimationEventTooltipArrow =>
                Styles.Get(Keys.AnimationEventTooltipArrow, EditorSkin.Scene);

            public static GUIStyle AnimationKeyframeBackground =>
                Styles.Get(Keys.AnimationKeyframeBackground, EditorSkin.Scene);

            public static GUIStyle AnimationPlayHead => Styles.Get(Keys.AnimationPlayHead, EditorSkin.Scene);
            public static GUIStyle AnimationRowEven => Styles.Get(Keys.AnimationRowEven, EditorSkin.Scene);
            public static GUIStyle AnimationRowOdd => Styles.Get(Keys.AnimationRowOdd, EditorSkin.Scene);

            public static GUIStyle AnimationSelectionTextField =>
                Styles.Get(Keys.AnimationSelectionTextField, EditorSkin.Scene);

            public static GUIStyle AnimationTimelineTick => Styles.Get(Keys.AnimationTimelineTick, EditorSkin.Scene);
            public static GUIStyle AnimClipToolbar => Styles.Get(Keys.AnimClipToolbar, EditorSkin.Scene);
            public static GUIStyle AnimClipToolbarButton => Styles.Get(Keys.AnimClipToolbarButton, EditorSkin.Scene);
            public static GUIStyle AnimClipToolbarPopup => Styles.Get(Keys.AnimClipToolbarPopup, EditorSkin.Scene);
            public static GUIStyle AnimItemBackground => Styles.Get(Keys.AnimItemBackground, EditorSkin.Scene);
            public static GUIStyle AnimLeftPaneSeparator => Styles.Get(Keys.AnimLeftPaneSeparator, EditorSkin.Scene);
            public static GUIStyle AnimPlayToolbar => Styles.Get(Keys.AnimPlayToolbar, EditorSkin.Scene);
            public static GUIStyle AnimPropDropdown => Styles.Get(Keys.AnimPropDropdown, EditorSkin.Scene);
            public static GUIStyle AppCommand => Styles.Get(Keys.AppCommand, EditorSkin.Scene);
            public static GUIStyle AppCommandLeft => Styles.Get(Keys.AppCommandLeft, EditorSkin.Scene);
            public static GUIStyle AppCommandLeftOn => Styles.Get(Keys.AppCommandLeftOn, EditorSkin.Scene);
            public static GUIStyle AppCommandMid => Styles.Get(Keys.AppCommandMid, EditorSkin.Scene);
            public static GUIStyle AppCommandRight => Styles.Get(Keys.AppCommandRight, EditorSkin.Scene);
            public static GUIStyle AppToolbar => Styles.Get(Keys.AppToolbar, EditorSkin.Scene);
            public static GUIStyle AppToolbarButtonLeft => Styles.Get(Keys.AppToolbarButtonLeft, EditorSkin.Scene);
            public static GUIStyle AppToolbarButtonMid => Styles.Get(Keys.AppToolbarButtonMid, EditorSkin.Scene);
            public static GUIStyle AppToolbarButtonRight => Styles.Get(Keys.AppToolbarButtonRight, EditorSkin.Scene);
            public static GUIStyle ArrowNavigationLeft => Styles.Get(Keys.ArrowNavigationLeft, EditorSkin.Scene);
            public static GUIStyle ArrowNavigationRight => Styles.Get(Keys.ArrowNavigationRight, EditorSkin.Scene);
            public static GUIStyle AssetLabel => Styles.Get(Keys.AssetLabel, EditorSkin.Scene);
            public static GUIStyle AssetLabel_Icon => Styles.Get(Keys.AssetLabel_Icon, EditorSkin.Scene);
            public static GUIStyle AssetLabel_Partial => Styles.Get(Keys.AssetLabel_Partial, EditorSkin.Scene);
            public static GUIStyle AvatarMappingBox => Styles.Get(Keys.AvatarMappingBox, EditorSkin.Scene);

            public static GUIStyle AvatarMappingErrorLabel =>
                Styles.Get(Keys.AvatarMappingErrorLabel, EditorSkin.Scene);

            public static GUIStyle AxisLabelNumberField => Styles.Get(Keys.AxisLabelNumberField, EditorSkin.Scene);
            public static GUIStyle Badge => Styles.Get(Keys.Badge, EditorSkin.Scene);
            public static GUIStyle BoldLabel => Styles.Get(Keys.BoldLabel, EditorSkin.Scene);
            public static GUIStyle BoldTextField => Styles.Get(Keys.BoldTextField, EditorSkin.Scene);
            public static GUIStyle BoldToggle => Styles.Get(Keys.BoldToggle, EditorSkin.Scene);
            public static GUIStyle BottomShadowInwards => Styles.Get(Keys.BottomShadowInwards, EditorSkin.Scene);
            public static GUIStyle BreadcrumbsSeparator => Styles.Get(Keys.BreadcrumbsSeparator, EditorSkin.Scene);
            public static GUIStyle ButtonLeft => Styles.Get(Keys.ButtonLeft, EditorSkin.Scene);
            public static GUIStyle ButtonMid => Styles.Get(Keys.ButtonMid, EditorSkin.Scene);
            public static GUIStyle ButtonRight => Styles.Get(Keys.ButtonRight, EditorSkin.Scene);
            public static GUIStyle BypassToggle => Styles.Get(Keys.BypassToggle, EditorSkin.Scene);
            public static GUIStyle CacheFolderLocation => Styles.Get(Keys.CacheFolderLocation, EditorSkin.Scene);
            public static GUIStyle CenteredLabel => Styles.Get(Keys.CenteredLabel, EditorSkin.Scene);

            public static GUIStyle ChannelStripAttenuationBar =>
                Styles.Get(Keys.ChannelStripAttenuationBar, EditorSkin.Scene);

            public static GUIStyle ChannelStripAttenuationMarkerSquare =>
                Styles.Get(Keys.ChannelStripAttenuationMarkerSquare, EditorSkin.Scene);

            public static GUIStyle ChannelStripBg => Styles.Get(Keys.ChannelStripBg, EditorSkin.Scene);

            public static GUIStyle ChannelStripDuckingMarker =>
                Styles.Get(Keys.ChannelStripDuckingMarker, EditorSkin.Scene);

            public static GUIStyle ChannelStripEffectBar => Styles.Get(Keys.ChannelStripEffectBar, EditorSkin.Scene);

            public static GUIStyle ChannelStripSendReturnBar =>
                Styles.Get(Keys.ChannelStripSendReturnBar, EditorSkin.Scene);

            public static GUIStyle ChannelStripVUMeterBg => Styles.Get(Keys.ChannelStripVUMeterBg, EditorSkin.Scene);
            public static GUIStyle CircularToggle => Styles.Get(Keys.CircularToggle, EditorSkin.Scene);
            public static GUIStyle CN_Box => Styles.Get(Keys.CN_Box, EditorSkin.Scene);
            public static GUIStyle CN_CenteredText => Styles.Get(Keys.CN_CenteredText, EditorSkin.Scene);
            public static GUIStyle CN_CountBadge => Styles.Get(Keys.CN_CountBadge, EditorSkin.Scene);
            public static GUIStyle CN_EntryBackEven => Styles.Get(Keys.CN_EntryBackEven, EditorSkin.Scene);
            public static GUIStyle CN_EntryBackOdd => Styles.Get(Keys.CN_EntryBackOdd, EditorSkin.Scene);
            public static GUIStyle CN_EntryError => Styles.Get(Keys.CN_EntryError, EditorSkin.Scene);
            public static GUIStyle CN_EntryErrorIcon => Styles.Get(Keys.CN_EntryErrorIcon, EditorSkin.Scene);
            public static GUIStyle CN_EntryErrorIconSmall => Styles.Get(Keys.CN_EntryErrorIconSmall, EditorSkin.Scene);
            public static GUIStyle CN_EntryErrorSmall => Styles.Get(Keys.CN_EntryErrorSmall, EditorSkin.Scene);
            public static GUIStyle CN_EntryInfo => Styles.Get(Keys.CN_EntryInfo, EditorSkin.Scene);
            public static GUIStyle CN_EntryInfoIcon => Styles.Get(Keys.CN_EntryInfoIcon, EditorSkin.Scene);
            public static GUIStyle CN_EntryInfoIconSmall => Styles.Get(Keys.CN_EntryInfoIconSmall, EditorSkin.Scene);
            public static GUIStyle CN_EntryInfoSmall => Styles.Get(Keys.CN_EntryInfoSmall, EditorSkin.Scene);
            public static GUIStyle CN_EntryWarn => Styles.Get(Keys.CN_EntryWarn, EditorSkin.Scene);
            public static GUIStyle CN_EntryWarnIcon => Styles.Get(Keys.CN_EntryWarnIcon, EditorSkin.Scene);
            public static GUIStyle CN_EntryWarnIconSmall => Styles.Get(Keys.CN_EntryWarnIconSmall, EditorSkin.Scene);
            public static GUIStyle CN_EntryWarnSmall => Styles.Get(Keys.CN_EntryWarnSmall, EditorSkin.Scene);
            public static GUIStyle CN_Message => Styles.Get(Keys.CN_Message, EditorSkin.Scene);

            public static GUIStyle CN_StacktraceBackground =>
                Styles.Get(Keys.CN_StacktraceBackground, EditorSkin.Scene);

            public static GUIStyle CN_StacktraceStyle => Styles.Get(Keys.CN_StacktraceStyle, EditorSkin.Scene);
            public static GUIStyle CN_StatusError => Styles.Get(Keys.CN_StatusError, EditorSkin.Scene);
            public static GUIStyle CN_StatusInfo => Styles.Get(Keys.CN_StatusInfo, EditorSkin.Scene);
            public static GUIStyle CN_StatusWarn => Styles.Get(Keys.CN_StatusWarn, EditorSkin.Scene);
            public static GUIStyle ColorField => Styles.Get(Keys.ColorField, EditorSkin.Scene);
            public static GUIStyle ColorPicker2DThumb => Styles.Get(Keys.ColorPicker2DThumb, EditorSkin.Scene);
            public static GUIStyle ColorPickerBackground => Styles.Get(Keys.ColorPickerBackground, EditorSkin.Scene);
            public static GUIStyle ColorPickerBox => Styles.Get(Keys.ColorPickerBox, EditorSkin.Scene);

            public static GUIStyle ColorPickerCurrentColor =>
                Styles.Get(Keys.ColorPickerCurrentColor, EditorSkin.Scene);

            public static GUIStyle ColorPickerCurrentExposureSwatchBorder =>
                Styles.Get(Keys.ColorPickerCurrentExposureSwatchBorder, EditorSkin.Scene);

            public static GUIStyle ColorPickerExposureSwatch =>
                Styles.Get(Keys.ColorPickerExposureSwatch, EditorSkin.Scene);

            public static GUIStyle ColorPickerHorizThumb => Styles.Get(Keys.ColorPickerHorizThumb, EditorSkin.Scene);
            public static GUIStyle ColorPickerHueRing => Styles.Get(Keys.ColorPickerHueRing, EditorSkin.Scene);
            public static GUIStyle ColorPickerHueRing_HDR => Styles.Get(Keys.ColorPickerHueRing_HDR, EditorSkin.Scene);

            public static GUIStyle ColorPickerHueRingThumb =>
                Styles.Get(Keys.ColorPickerHueRingThumb, EditorSkin.Scene);

            public static GUIStyle ColorPickerOriginalColor =>
                Styles.Get(Keys.ColorPickerOriginalColor, EditorSkin.Scene);

            public static GUIStyle ColorPickerSliderBackground =>
                Styles.Get(Keys.ColorPickerSliderBackground, EditorSkin.Scene);

            public static GUIStyle Command => Styles.Get(Keys.Command, EditorSkin.Scene);
            public static GUIStyle CommandLeft => Styles.Get(Keys.CommandLeft, EditorSkin.Scene);
            public static GUIStyle CommandMid => Styles.Get(Keys.CommandMid, EditorSkin.Scene);
            public static GUIStyle CommandRight => Styles.Get(Keys.CommandRight, EditorSkin.Scene);
            public static GUIStyle ContentToolbar => Styles.Get(Keys.ContentToolbar, EditorSkin.Scene);
            public static GUIStyle ControlHighlight => Styles.Get(Keys.ControlHighlight, EditorSkin.Scene);
            public static GUIStyle ControlLabel => Styles.Get(Keys.ControlLabel, EditorSkin.Scene);
            public static GUIStyle CurveEditorBackground => Styles.Get(Keys.CurveEditorBackground, EditorSkin.Scene);

            public static GUIStyle CurveEditorLabelTickmarks =>
                Styles.Get(Keys.CurveEditorLabelTickmarks, EditorSkin.Scene);

            public static GUIStyle CurveEditorLabelTickmarksOverflow =>
                Styles.Get(Keys.CurveEditorLabelTickmarksOverflow, EditorSkin.Scene);

            public static GUIStyle CurveEditorRightAlignedLabel =>
                Styles.Get(Keys.CurveEditorRightAlignedLabel, EditorSkin.Scene);

            public static GUIStyle DD_Background => Styles.Get(Keys.DD_Background, EditorSkin.Scene);
            public static GUIStyle DD_HeaderStyle => Styles.Get(Keys.DD_HeaderStyle, EditorSkin.Scene);
            public static GUIStyle DD_ItemCheckmark => Styles.Get(Keys.DD_ItemCheckmark, EditorSkin.Scene);
            public static GUIStyle DD_ItemStyle => Styles.Get(Keys.DD_ItemStyle, EditorSkin.Scene);
            public static GUIStyle DD_LargeItemStyle => Styles.Get(Keys.DD_LargeItemStyle, EditorSkin.Scene);

            public static GUIStyle DefaultCenteredLargeText =>
                Styles.Get(Keys.DefaultCenteredLargeText, EditorSkin.Scene);

            public static GUIStyle DefaultCenteredText => Styles.Get(Keys.DefaultCenteredText, EditorSkin.Scene);
            public static GUIStyle DefaultLineSeparator => Styles.Get(Keys.DefaultLineSeparator, EditorSkin.Scene);
            public static GUIStyle dockarea => Styles.Get(Keys.dockarea, EditorSkin.Scene);
            public static GUIStyle dockareaOverlay => Styles.Get(Keys.dockareaOverlay, EditorSkin.Scene);
            public static GUIStyle dockareaStandalone => Styles.Get(Keys.dockareaStandalone, EditorSkin.Scene);
            public static GUIStyle dockHeader => Styles.Get(Keys.dockHeader, EditorSkin.Scene);
            public static GUIStyle DopesheetBackground => Styles.Get(Keys.DopesheetBackground, EditorSkin.Scene);
            public static GUIStyle Dopesheetkeyframe => Styles.Get(Keys.Dopesheetkeyframe, EditorSkin.Scene);
            public static GUIStyle DopesheetRippleLeft => Styles.Get(Keys.DopesheetRippleLeft, EditorSkin.Scene);
            public static GUIStyle DopesheetRippleRight => Styles.Get(Keys.DopesheetRippleRight, EditorSkin.Scene);
            public static GUIStyle DopesheetScaleLeft => Styles.Get(Keys.DopesheetScaleLeft, EditorSkin.Scene);
            public static GUIStyle DopesheetScaleRight => Styles.Get(Keys.DopesheetScaleRight, EditorSkin.Scene);
            public static GUIStyle dragtab => Styles.Get(Keys.dragtab, EditorSkin.Scene);
            public static GUIStyle dragtab_first => Styles.Get(Keys.dragtab_first, EditorSkin.Scene);
            public static GUIStyle dragtab_scroller_next => Styles.Get(Keys.dragtab_scroller_next, EditorSkin.Scene);
            public static GUIStyle dragtab_scroller_prev => Styles.Get(Keys.dragtab_scroller_prev, EditorSkin.Scene);
            public static GUIStyle dragtabdropwindow => Styles.Get(Keys.dragtabdropwindow, EditorSkin.Scene);
            public static GUIStyle DropDown => Styles.Get(Keys.DropDown, EditorSkin.Scene);
            public static GUIStyle DropDownButton => Styles.Get(Keys.DropDownButton, EditorSkin.Scene);
            public static GUIStyle DropzoneStyle => Styles.Get(Keys.DropzoneStyle, EditorSkin.Scene);
            public static GUIStyle EditModeSingleButton => Styles.Get(Keys.EditModeSingleButton, EditorSkin.Scene);
            public static GUIStyle ErrorLabel => Styles.Get(Keys.ErrorLabel, EditorSkin.Scene);
            public static GUIStyle ExposablePopupItem => Styles.Get(Keys.ExposablePopupItem, EditorSkin.Scene);
            public static GUIStyle ExposablePopupMenu => Styles.Get(Keys.ExposablePopupMenu, EditorSkin.Scene);

            public static GUIStyle EyeDropperHorizontalLine =>
                Styles.Get(Keys.EyeDropperHorizontalLine, EditorSkin.Scene);

            public static GUIStyle EyeDropperPickedPixel => Styles.Get(Keys.EyeDropperPickedPixel, EditorSkin.Scene);
            public static GUIStyle EyeDropperVerticalLine => Styles.Get(Keys.EyeDropperVerticalLine, EditorSkin.Scene);
            public static GUIStyle FloatFieldLinkButton => Styles.Get(Keys.FloatFieldLinkButton, EditorSkin.Scene);
            public static GUIStyle flow_background => Styles.Get(Keys.flow_background, EditorSkin.Scene);
            public static GUIStyle flow_node_0 => Styles.Get(Keys.flow_node_0, EditorSkin.Scene);
            public static GUIStyle flow_node_0_on => Styles.Get(Keys.flow_node_0_on, EditorSkin.Scene);
            public static GUIStyle flow_node_1 => Styles.Get(Keys.flow_node_1, EditorSkin.Scene);
            public static GUIStyle flow_node_1_on => Styles.Get(Keys.flow_node_1_on, EditorSkin.Scene);
            public static GUIStyle flow_node_2 => Styles.Get(Keys.flow_node_2, EditorSkin.Scene);
            public static GUIStyle flow_node_2_on => Styles.Get(Keys.flow_node_2_on, EditorSkin.Scene);
            public static GUIStyle flow_node_3 => Styles.Get(Keys.flow_node_3, EditorSkin.Scene);
            public static GUIStyle flow_node_3_on => Styles.Get(Keys.flow_node_3_on, EditorSkin.Scene);
            public static GUIStyle flow_node_4 => Styles.Get(Keys.flow_node_4, EditorSkin.Scene);
            public static GUIStyle flow_node_4_on => Styles.Get(Keys.flow_node_4_on, EditorSkin.Scene);
            public static GUIStyle flow_node_5 => Styles.Get(Keys.flow_node_5, EditorSkin.Scene);
            public static GUIStyle flow_node_5_on => Styles.Get(Keys.flow_node_5_on, EditorSkin.Scene);
            public static GUIStyle flow_node_6 => Styles.Get(Keys.flow_node_6, EditorSkin.Scene);
            public static GUIStyle flow_node_6_on => Styles.Get(Keys.flow_node_6_on, EditorSkin.Scene);
            public static GUIStyle flow_node_base => Styles.Get(Keys.flow_node_base, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_0 => Styles.Get(Keys.flow_node_hex_0, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_0_on => Styles.Get(Keys.flow_node_hex_0_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_1 => Styles.Get(Keys.flow_node_hex_1, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_1_on => Styles.Get(Keys.flow_node_hex_1_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_2 => Styles.Get(Keys.flow_node_hex_2, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_2_on => Styles.Get(Keys.flow_node_hex_2_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_3 => Styles.Get(Keys.flow_node_hex_3, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_3_on => Styles.Get(Keys.flow_node_hex_3_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_4 => Styles.Get(Keys.flow_node_hex_4, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_4_on => Styles.Get(Keys.flow_node_hex_4_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_5 => Styles.Get(Keys.flow_node_hex_5, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_5_on => Styles.Get(Keys.flow_node_hex_5_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_6 => Styles.Get(Keys.flow_node_hex_6, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_6_on => Styles.Get(Keys.flow_node_hex_6_on, EditorSkin.Scene);
            public static GUIStyle flow_node_hex_base => Styles.Get(Keys.flow_node_hex_base, EditorSkin.Scene);
            public static GUIStyle flow_node_titlebar => Styles.Get(Keys.flow_node_titlebar, EditorSkin.Scene);
            public static GUIStyle flow_target_in => Styles.Get(Keys.flow_target_in, EditorSkin.Scene);
            public static GUIStyle flow_triggerPin_in => Styles.Get(Keys.flow_triggerPin_in, EditorSkin.Scene);
            public static GUIStyle flow_triggerPin_out => Styles.Get(Keys.flow_triggerPin_out, EditorSkin.Scene);
            public static GUIStyle flow_varPin_in => Styles.Get(Keys.flow_varPin_in, EditorSkin.Scene);
            public static GUIStyle flow_varPin_out => Styles.Get(Keys.flow_varPin_out, EditorSkin.Scene);
            public static GUIStyle flow_varPin_tooltip => Styles.Get(Keys.flow_varPin_tooltip, EditorSkin.Scene);
            public static GUIStyle Foldout => Styles.Get(Keys.Foldout, EditorSkin.Scene);
            public static GUIStyle FoldoutHeader => Styles.Get(Keys.FoldoutHeader, EditorSkin.Scene);
            public static GUIStyle FoldoutHeaderIcon => Styles.Get(Keys.FoldoutHeaderIcon, EditorSkin.Scene);
            public static GUIStyle FoldOutPreDrop => Styles.Get(Keys.FoldOutPreDrop, EditorSkin.Scene);
            public static GUIStyle Frame => Styles.Get(Keys.Frame, EditorSkin.Scene);
            public static GUIStyle FrameBox => Styles.Get(Keys.FrameBox, EditorSkin.Scene);
            public static GUIStyle GameViewBackground => Styles.Get(Keys.GameViewBackground, EditorSkin.Scene);
            public static GUIStyle Grad_Down_Swatch => Styles.Get(Keys.Grad_Down_Swatch, EditorSkin.Scene);

            public static GUIStyle Grad_Down_Swatch_Overlay =>
                Styles.Get(Keys.Grad_Down_Swatch_Overlay, EditorSkin.Scene);

            public static GUIStyle Grad_Up_Swatch => Styles.Get(Keys.Grad_Up_Swatch, EditorSkin.Scene);
            public static GUIStyle Grad_Up_Swatch_Overlay => Styles.Get(Keys.Grad_Up_Swatch_Overlay, EditorSkin.Scene);
            public static GUIStyle grey_border => Styles.Get(Keys.grey_border, EditorSkin.Scene);
            public static GUIStyle GridList => Styles.Get(Keys.GridList, EditorSkin.Scene);
            public static GUIStyle GridListText => Styles.Get(Keys.GridListText, EditorSkin.Scene);
            public static GUIStyle GroupBox => Styles.Get(Keys.GroupBox, EditorSkin.Scene);

            public static GUIStyle GUIEditor_BreadcrumbLeft =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeft, EditorSkin.Scene);

            public static GUIStyle GUIEditor_BreadcrumbLeftBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbLeftBackground, EditorSkin.Scene);

            public static GUIStyle GUIEditor_BreadcrumbMid =>
                Styles.Get(Keys.GUIEditor_BreadcrumbMid, EditorSkin.Scene);

            public static GUIStyle GUIEditor_BreadcrumbMidBackground =>
                Styles.Get(Keys.GUIEditor_BreadcrumbMidBackground, EditorSkin.Scene);

            public static GUIStyle GV_Gizmo_DropDown => Styles.Get(Keys.GV_Gizmo_DropDown, EditorSkin.Scene);
            public static GUIStyle HeaderButton => Styles.Get(Keys.HeaderButton, EditorSkin.Scene);
            public static GUIStyle HeaderLabel => Styles.Get(Keys.HeaderLabel, EditorSkin.Scene);
            public static GUIStyle HelpBox => Styles.Get(Keys.HelpBox, EditorSkin.Scene);
            public static GUIStyle Hi_Label => Styles.Get(Keys.Hi_Label, EditorSkin.Scene);

            public static GUIStyle HorizontalMinMaxScrollbarThumb =>
                Styles.Get(Keys.HorizontalMinMaxScrollbarThumb, EditorSkin.Scene);

            public static GUIStyle HorizontalSliderThumbExtent =>
                Styles.Get(Keys.HorizontalSliderThumbExtent, EditorSkin.Scene);

            public static GUIStyle hostview => Styles.Get(Keys.hostview, EditorSkin.Scene);
            public static GUIStyle IconButton => Styles.Get(Keys.IconButton, EditorSkin.Scene);
            public static GUIStyle IN_BigTitle => Styles.Get(Keys.IN_BigTitle, EditorSkin.Scene);
            public static GUIStyle IN_BigTitle_Inner => Styles.Get(Keys.IN_BigTitle_Inner, EditorSkin.Scene);
            public static GUIStyle IN_BigTitle_Post => Styles.Get(Keys.IN_BigTitle_Post, EditorSkin.Scene);
            public static GUIStyle IN_CenteredLabel => Styles.Get(Keys.IN_CenteredLabel, EditorSkin.Scene);
            public static GUIStyle IN_DropDown => Styles.Get(Keys.IN_DropDown, EditorSkin.Scene);
            public static GUIStyle IN_EditColliderButton => Styles.Get(Keys.IN_EditColliderButton, EditorSkin.Scene);
            public static GUIStyle IN_Foldout => Styles.Get(Keys.IN_Foldout, EditorSkin.Scene);
            public static GUIStyle IN_Footer => Styles.Get(Keys.IN_Footer, EditorSkin.Scene);
            public static GUIStyle IN_Label => Styles.Get(Keys.IN_Label, EditorSkin.Scene);
            public static GUIStyle IN_LockButton => Styles.Get(Keys.IN_LockButton, EditorSkin.Scene);
            public static GUIStyle IN_MinMaxStateDropDown => Styles.Get(Keys.IN_MinMaxStateDropDown, EditorSkin.Scene);
            public static GUIStyle IN_ObjectField => Styles.Get(Keys.IN_ObjectField, EditorSkin.Scene);
            public static GUIStyle IN_TextField => Styles.Get(Keys.IN_TextField, EditorSkin.Scene);
            public static GUIStyle IN_ThumbnailSelection => Styles.Get(Keys.IN_ThumbnailSelection, EditorSkin.Scene);
            public static GUIStyle IN_ThumbnailShadow => Styles.Get(Keys.IN_ThumbnailShadow, EditorSkin.Scene);
            public static GUIStyle IN_Title => Styles.Get(Keys.IN_Title, EditorSkin.Scene);
            public static GUIStyle IN_Title_Flat => Styles.Get(Keys.IN_Title_Flat, EditorSkin.Scene);
            public static GUIStyle IN_TitleText => Styles.Get(Keys.IN_TitleText, EditorSkin.Scene);
            public static GUIStyle IN_TypeSelection => Styles.Get(Keys.IN_TypeSelection, EditorSkin.Scene);
            public static GUIStyle InnerShadowBg => Styles.Get(Keys.InnerShadowBg, EditorSkin.Scene);
            public static GUIStyle InsertionMarker => Styles.Get(Keys.InsertionMarker, EditorSkin.Scene);
            public static GUIStyle InvisibleButton => Styles.Get(Keys.InvisibleButton, EditorSkin.Scene);
            public static GUIStyle LargeBoldLabel => Styles.Get(Keys.LargeBoldLabel, EditorSkin.Scene);
            public static GUIStyle LargeButton => Styles.Get(Keys.LargeButton, EditorSkin.Scene);
            public static GUIStyle LargeButtonLeft => Styles.Get(Keys.LargeButtonLeft, EditorSkin.Scene);
            public static GUIStyle LargeButtonMid => Styles.Get(Keys.LargeButtonMid, EditorSkin.Scene);
            public static GUIStyle LargeButtonRight => Styles.Get(Keys.LargeButtonRight, EditorSkin.Scene);
            public static GUIStyle LargeLabel => Styles.Get(Keys.LargeLabel, EditorSkin.Scene);

            public static GUIStyle LightmapEditorSelectedHighlight =>
                Styles.Get(Keys.LightmapEditorSelectedHighlight, EditorSkin.Scene);

            public static GUIStyle LinkLabel => Styles.Get(Keys.LinkLabel, EditorSkin.Scene);
            public static GUIStyle LODBlackBox => Styles.Get(Keys.LODBlackBox, EditorSkin.Scene);
            public static GUIStyle LODCameraLine => Styles.Get(Keys.LODCameraLine, EditorSkin.Scene);
            public static GUIStyle LODLevelNotifyText => Styles.Get(Keys.LODLevelNotifyText, EditorSkin.Scene);
            public static GUIStyle LODRendererAddButton => Styles.Get(Keys.LODRendererAddButton, EditorSkin.Scene);
            public static GUIStyle LODRendererButton => Styles.Get(Keys.LODRendererButton, EditorSkin.Scene);
            public static GUIStyle LODRendererRemove => Styles.Get(Keys.LODRendererRemove, EditorSkin.Scene);
            public static GUIStyle LODRenderersText => Styles.Get(Keys.LODRenderersText, EditorSkin.Scene);
            public static GUIStyle LODSceneText => Styles.Get(Keys.LODSceneText, EditorSkin.Scene);
            public static GUIStyle LODSliderBG => Styles.Get(Keys.LODSliderBG, EditorSkin.Scene);
            public static GUIStyle LODSliderRange => Styles.Get(Keys.LODSliderRange, EditorSkin.Scene);
            public static GUIStyle LODSliderRangeSelected => Styles.Get(Keys.LODSliderRangeSelected, EditorSkin.Scene);
            public static GUIStyle LODSliderText => Styles.Get(Keys.LODSliderText, EditorSkin.Scene);
            public static GUIStyle LODSliderTextSelected => Styles.Get(Keys.LODSliderTextSelected, EditorSkin.Scene);
            public static GUIStyle MeBlendBackground => Styles.Get(Keys.MeBlendBackground, EditorSkin.Scene);
            public static GUIStyle MeBlendPosition => Styles.Get(Keys.MeBlendPosition, EditorSkin.Scene);
            public static GUIStyle MeBlendTriangleLeft => Styles.Get(Keys.MeBlendTriangleLeft, EditorSkin.Scene);
            public static GUIStyle MeBlendTriangleRight => Styles.Get(Keys.MeBlendTriangleRight, EditorSkin.Scene);
            public static GUIStyle MeLivePlayBackground => Styles.Get(Keys.MeLivePlayBackground, EditorSkin.Scene);
            public static GUIStyle MeLivePlayBar => Styles.Get(Keys.MeLivePlayBar, EditorSkin.Scene);
            public static GUIStyle MenuItem => Styles.Get(Keys.MenuItem, EditorSkin.Scene);
            public static GUIStyle MenuItemMixed => Styles.Get(Keys.MenuItemMixed, EditorSkin.Scene);
            public static GUIStyle MenuToggleItem => Styles.Get(Keys.MenuToggleItem, EditorSkin.Scene);
            public static GUIStyle MeTimeBlockLeft => Styles.Get(Keys.MeTimeBlockLeft, EditorSkin.Scene);
            public static GUIStyle MeTimeBlockRight => Styles.Get(Keys.MeTimeBlockRight, EditorSkin.Scene);
            public static GUIStyle MeTimeLabel => Styles.Get(Keys.MeTimeLabel, EditorSkin.Scene);
            public static GUIStyle MeTransitionBack => Styles.Get(Keys.MeTransitionBack, EditorSkin.Scene);
            public static GUIStyle MeTransitionBlock => Styles.Get(Keys.MeTransitionBlock, EditorSkin.Scene);
            public static GUIStyle MeTransitionHandleLeft => Styles.Get(Keys.MeTransitionHandleLeft, EditorSkin.Scene);

            public static GUIStyle MeTransitionHandleLeftPrev =>
                Styles.Get(Keys.MeTransitionHandleLeftPrev, EditorSkin.Scene);

            public static GUIStyle MeTransitionHandleRight =>
                Styles.Get(Keys.MeTransitionHandleRight, EditorSkin.Scene);

            public static GUIStyle MeTransitionHead => Styles.Get(Keys.MeTransitionHead, EditorSkin.Scene);
            public static GUIStyle MeTransitionSelect => Styles.Get(Keys.MeTransitionSelect, EditorSkin.Scene);
            public static GUIStyle MeTransitionSelectHead => Styles.Get(Keys.MeTransitionSelectHead, EditorSkin.Scene);
            public static GUIStyle MeTransOff2On => Styles.Get(Keys.MeTransOff2On, EditorSkin.Scene);
            public static GUIStyle MeTransOffLeft => Styles.Get(Keys.MeTransOffLeft, EditorSkin.Scene);
            public static GUIStyle MeTransOffRight => Styles.Get(Keys.MeTransOffRight, EditorSkin.Scene);
            public static GUIStyle MeTransOn2Off => Styles.Get(Keys.MeTransOn2Off, EditorSkin.Scene);
            public static GUIStyle MeTransOnLeft => Styles.Get(Keys.MeTransOnLeft, EditorSkin.Scene);
            public static GUIStyle MeTransOnRight => Styles.Get(Keys.MeTransOnRight, EditorSkin.Scene);
            public static GUIStyle MeTransPlayhead => Styles.Get(Keys.MeTransPlayhead, EditorSkin.Scene);
            public static GUIStyle MiniBoldLabel => Styles.Get(Keys.MiniBoldLabel, EditorSkin.Scene);
            public static GUIStyle minibutton => Styles.Get(Keys.minibutton, EditorSkin.Scene);
            public static GUIStyle minibuttonleft => Styles.Get(Keys.minibuttonleft, EditorSkin.Scene);
            public static GUIStyle minibuttonmid => Styles.Get(Keys.minibuttonmid, EditorSkin.Scene);
            public static GUIStyle minibuttonright => Styles.Get(Keys.minibuttonright, EditorSkin.Scene);
            public static GUIStyle MiniLabel => Styles.Get(Keys.MiniLabel, EditorSkin.Scene);

            public static GUIStyle MiniMinMaxSliderHorizontal =>
                Styles.Get(Keys.MiniMinMaxSliderHorizontal, EditorSkin.Scene);

            public static GUIStyle MiniMinMaxSliderVertical =>
                Styles.Get(Keys.MiniMinMaxSliderVertical, EditorSkin.Scene);

            public static GUIStyle MiniPopup => Styles.Get(Keys.MiniPopup, EditorSkin.Scene);
            public static GUIStyle MiniPullDown => Styles.Get(Keys.MiniPullDown, EditorSkin.Scene);
            public static GUIStyle MiniSliderHorizontal => Styles.Get(Keys.MiniSliderHorizontal, EditorSkin.Scene);
            public static GUIStyle MiniSliderVertical => Styles.Get(Keys.MiniSliderVertical, EditorSkin.Scene);
            public static GUIStyle MiniTextField => Styles.Get(Keys.MiniTextField, EditorSkin.Scene);
            public static GUIStyle MiniToolbarButton => Styles.Get(Keys.MiniToolbarButton, EditorSkin.Scene);
            public static GUIStyle MiniToolbarButtonLeft => Styles.Get(Keys.MiniToolbarButtonLeft, EditorSkin.Scene);

            public static GUIStyle MinMaxHorizontalSliderThumb =>
                Styles.Get(Keys.MinMaxHorizontalSliderThumb, EditorSkin.Scene);

            public static GUIStyle MultiColumnArrow => Styles.Get(Keys.MultiColumnArrow, EditorSkin.Scene);
            public static GUIStyle MultiColumnHeader => Styles.Get(Keys.MultiColumnHeader, EditorSkin.Scene);

            public static GUIStyle MultiColumnHeaderCenter =>
                Styles.Get(Keys.MultiColumnHeaderCenter, EditorSkin.Scene);

            public static GUIStyle MultiColumnHeaderRight => Styles.Get(Keys.MultiColumnHeaderRight, EditorSkin.Scene);
            public static GUIStyle MultiColumnTopBar => Styles.Get(Keys.MultiColumnTopBar, EditorSkin.Scene);
            public static GUIStyle MuteToggle => Styles.Get(Keys.MuteToggle, EditorSkin.Scene);
            public static GUIStyle NotificationBackground => Styles.Get(Keys.NotificationBackground, EditorSkin.Scene);
            public static GUIStyle NotificationText => Styles.Get(Keys.NotificationText, EditorSkin.Scene);
            public static GUIStyle ObjectField => Styles.Get(Keys.ObjectField, EditorSkin.Scene);
            public static GUIStyle ObjectFieldButton => Styles.Get(Keys.ObjectFieldButton, EditorSkin.Scene);
            public static GUIStyle ObjectFieldMiniThumb => Styles.Get(Keys.ObjectFieldMiniThumb, EditorSkin.Scene);
            public static GUIStyle ObjectFieldThumb => Styles.Get(Keys.ObjectFieldThumb, EditorSkin.Scene);

            public static GUIStyle ObjectFieldThumbLightmapPreviewOverlay =>
                Styles.Get(Keys.ObjectFieldThumbLightmapPreviewOverlay, EditorSkin.Scene);

            public static GUIStyle ObjectFieldThumbOverlay =>
                Styles.Get(Keys.ObjectFieldThumbOverlay, EditorSkin.Scene);

            public static GUIStyle ObjectFieldThumbOverlay2 =>
                Styles.Get(Keys.ObjectFieldThumbOverlay2, EditorSkin.Scene);

            public static GUIStyle ObjectPickerBackground => Styles.Get(Keys.ObjectPickerBackground, EditorSkin.Scene);

            public static GUIStyle ObjectPickerLargeStatus =>
                Styles.Get(Keys.ObjectPickerLargeStatus, EditorSkin.Scene);

            public static GUIStyle ObjectPickerPreviewBackground =>
                Styles.Get(Keys.ObjectPickerPreviewBackground, EditorSkin.Scene);

            public static GUIStyle ObjectPickerResultsEven =>
                Styles.Get(Keys.ObjectPickerResultsEven, EditorSkin.Scene);

            public static GUIStyle ObjectPickerResultsGrid =>
                Styles.Get(Keys.ObjectPickerResultsGrid, EditorSkin.Scene);

            public static GUIStyle ObjectPickerResultsOdd => Styles.Get(Keys.ObjectPickerResultsOdd, EditorSkin.Scene);

            public static GUIStyle ObjectPickerSmallStatus =>
                Styles.Get(Keys.ObjectPickerSmallStatus, EditorSkin.Scene);

            public static GUIStyle ObjectPickerTab => Styles.Get(Keys.ObjectPickerTab, EditorSkin.Scene);
            public static GUIStyle ObjectPickerToolbar => Styles.Get(Keys.ObjectPickerToolbar, EditorSkin.Scene);
            public static GUIStyle OffsetDropDown => Styles.Get(Keys.OffsetDropDown, EditorSkin.Scene);
            public static GUIStyle OL_box => Styles.Get(Keys.OL_box, EditorSkin.Scene);
            public static GUIStyle OL_box_flat => Styles.Get(Keys.OL_box_flat, EditorSkin.Scene);
            public static GUIStyle OL_box_NoExpand => Styles.Get(Keys.OL_box_NoExpand, EditorSkin.Scene);
            public static GUIStyle OL_EntryBackEven => Styles.Get(Keys.OL_EntryBackEven, EditorSkin.Scene);
            public static GUIStyle OL_EntryBackOdd => Styles.Get(Keys.OL_EntryBackOdd, EditorSkin.Scene);
            public static GUIStyle OL_Label => Styles.Get(Keys.OL_Label, EditorSkin.Scene);
            public static GUIStyle OL_MiniPing => Styles.Get(Keys.OL_MiniPing, EditorSkin.Scene);
            public static GUIStyle OL_MiniRenameField => Styles.Get(Keys.OL_MiniRenameField, EditorSkin.Scene);
            public static GUIStyle OL_Minus => Styles.Get(Keys.OL_Minus, EditorSkin.Scene);
            public static GUIStyle OL_Ping => Styles.Get(Keys.OL_Ping, EditorSkin.Scene);
            public static GUIStyle OL_Plus => Styles.Get(Keys.OL_Plus, EditorSkin.Scene);
            public static GUIStyle OL_ResultFocusMarker => Styles.Get(Keys.OL_ResultFocusMarker, EditorSkin.Scene);
            public static GUIStyle OL_ResultLabel => Styles.Get(Keys.OL_ResultLabel, EditorSkin.Scene);
            public static GUIStyle OL_RightLabel => Styles.Get(Keys.OL_RightLabel, EditorSkin.Scene);
            public static GUIStyle OL_SelectedRow => Styles.Get(Keys.OL_SelectedRow, EditorSkin.Scene);
            public static GUIStyle OL_Title => Styles.Get(Keys.OL_Title, EditorSkin.Scene);
            public static GUIStyle OL_Title_TextRight => Styles.Get(Keys.OL_Title_TextRight, EditorSkin.Scene);
            public static GUIStyle OL_Toggle => Styles.Get(Keys.OL_Toggle, EditorSkin.Scene);
            public static GUIStyle OL_ToggleMixed => Styles.Get(Keys.OL_ToggleMixed, EditorSkin.Scene);
            public static GUIStyle OL_ToggleWhite => Styles.Get(Keys.OL_ToggleWhite, EditorSkin.Scene);
            public static GUIStyle OT_BottomBar => Styles.Get(Keys.OT_BottomBar, EditorSkin.Scene);
            public static GUIStyle OT_TopBar => Styles.Get(Keys.OT_TopBar, EditorSkin.Scene);
            public static GUIStyle OverrideMargin => Styles.Get(Keys.OverrideMargin, EditorSkin.Scene);
            public static GUIStyle PaneOptions => Styles.Get(Keys.PaneOptions, EditorSkin.Scene);
            public static GUIStyle PlayerSettingsLevel => Styles.Get(Keys.PlayerSettingsLevel, EditorSkin.Scene);
            public static GUIStyle PlayerSettingsPlatform => Styles.Get(Keys.PlayerSettingsPlatform, EditorSkin.Scene);
            public static GUIStyle Popup => Styles.Get(Keys.Popup, EditorSkin.Scene);
            public static GUIStyle PopupCurveDropdown => Styles.Get(Keys.PopupCurveDropdown, EditorSkin.Scene);

            public static GUIStyle PopupCurveEditorBackground =>
                Styles.Get(Keys.PopupCurveEditorBackground, EditorSkin.Scene);

            public static GUIStyle PopupCurveEditorSwatch => Styles.Get(Keys.PopupCurveEditorSwatch, EditorSkin.Scene);

            public static GUIStyle PopupCurveSwatchBackground =>
                Styles.Get(Keys.PopupCurveSwatchBackground, EditorSkin.Scene);

            public static GUIStyle PR_BrokenPrefabLabel => Styles.Get(Keys.PR_BrokenPrefabLabel, EditorSkin.Scene);

            public static GUIStyle PR_DisabledBrokenPrefabLabel =>
                Styles.Get(Keys.PR_DisabledBrokenPrefabLabel, EditorSkin.Scene);

            public static GUIStyle PR_DisabledLabel => Styles.Get(Keys.PR_DisabledLabel, EditorSkin.Scene);
            public static GUIStyle PR_DisabledPrefabLabel => Styles.Get(Keys.PR_DisabledPrefabLabel, EditorSkin.Scene);
            public static GUIStyle PR_Insertion => Styles.Get(Keys.PR_Insertion, EditorSkin.Scene);
            public static GUIStyle PR_Label => Styles.Get(Keys.PR_Label, EditorSkin.Scene);
            public static GUIStyle PR_Ping => Styles.Get(Keys.PR_Ping, EditorSkin.Scene);
            public static GUIStyle PR_PrefabLabel => Styles.Get(Keys.PR_PrefabLabel, EditorSkin.Scene);
            public static GUIStyle PR_TextField => Styles.Get(Keys.PR_TextField, EditorSkin.Scene);
            public static GUIStyle PreBackground => Styles.Get(Keys.PreBackground, EditorSkin.Scene);
            public static GUIStyle PreBackgroundSolid => Styles.Get(Keys.PreBackgroundSolid, EditorSkin.Scene);
            public static GUIStyle PreButton => Styles.Get(Keys.PreButton, EditorSkin.Scene);
            public static GUIStyle PreButtonBlue => Styles.Get(Keys.PreButtonBlue, EditorSkin.Scene);
            public static GUIStyle PreButtonGreen => Styles.Get(Keys.PreButtonGreen, EditorSkin.Scene);
            public static GUIStyle PreButtonRed => Styles.Get(Keys.PreButtonRed, EditorSkin.Scene);
            public static GUIStyle PreDropDown => Styles.Get(Keys.PreDropDown, EditorSkin.Scene);
            public static GUIStyle PreferencesKeysElement => Styles.Get(Keys.PreferencesKeysElement, EditorSkin.Scene);
            public static GUIStyle PreferencesSection => Styles.Get(Keys.PreferencesSection, EditorSkin.Scene);
            public static GUIStyle PreferencesSectionBox => Styles.Get(Keys.PreferencesSectionBox, EditorSkin.Scene);
            public static GUIStyle PrefixLabel => Styles.Get(Keys.PrefixLabel, EditorSkin.Scene);
            public static GUIStyle PreHorizontalScrollbar => Styles.Get(Keys.PreHorizontalScrollbar, EditorSkin.Scene);

            public static GUIStyle PreHorizontalScrollbarThumb =>
                Styles.Get(Keys.PreHorizontalScrollbarThumb, EditorSkin.Scene);

            public static GUIStyle PreLabel => Styles.Get(Keys.PreLabel, EditorSkin.Scene);
            public static GUIStyle PreLabelUpper => Styles.Get(Keys.PreLabelUpper, EditorSkin.Scene);
            public static GUIStyle PreMiniLabel => Styles.Get(Keys.PreMiniLabel, EditorSkin.Scene);
            public static GUIStyle PreOverlayLabel => Styles.Get(Keys.PreOverlayLabel, EditorSkin.Scene);
            public static GUIStyle PreSlider => Styles.Get(Keys.PreSlider, EditorSkin.Scene);
            public static GUIStyle PreSliderThumb => Styles.Get(Keys.PreSliderThumb, EditorSkin.Scene);
            public static GUIStyle PreToolbar => Styles.Get(Keys.PreToolbar, EditorSkin.Scene);
            public static GUIStyle PreToolbar2 => Styles.Get(Keys.PreToolbar2, EditorSkin.Scene);
            public static GUIStyle PreVerticalScrollbar => Styles.Get(Keys.PreVerticalScrollbar, EditorSkin.Scene);

            public static GUIStyle PreVerticalScrollbarThumb =>
                Styles.Get(Keys.PreVerticalScrollbarThumb, EditorSkin.Scene);

            public static GUIStyle PreviewPackageInUse => Styles.Get(Keys.PreviewPackageInUse, EditorSkin.Scene);
            public static GUIStyle ProfilerBadge => Styles.Get(Keys.ProfilerBadge, EditorSkin.Scene);

            public static GUIStyle ProfilerDetailViewBackground =>
                Styles.Get(Keys.ProfilerDetailViewBackground, EditorSkin.Scene);

            public static GUIStyle ProfilerGraphBackground =>
                Styles.Get(Keys.ProfilerGraphBackground, EditorSkin.Scene);

            public static GUIStyle ProfilerHeaderLabel => Styles.Get(Keys.ProfilerHeaderLabel, EditorSkin.Scene);
            public static GUIStyle ProfilerLeftPane => Styles.Get(Keys.ProfilerLeftPane, EditorSkin.Scene);

            public static GUIStyle ProfilerNoDataAvailable =>
                Styles.Get(Keys.ProfilerNoDataAvailable, EditorSkin.Scene);

            public static GUIStyle ProfilerNotSupportedWarningLabel =>
                Styles.Get(Keys.ProfilerNotSupportedWarningLabel, EditorSkin.Scene);

            public static GUIStyle ProfilerPaneSubLabel => Styles.Get(Keys.ProfilerPaneSubLabel, EditorSkin.Scene);
            public static GUIStyle ProfilerRightPane => Styles.Get(Keys.ProfilerRightPane, EditorSkin.Scene);

            public static GUIStyle ProfilerScrollviewBackground =>
                Styles.Get(Keys.ProfilerScrollviewBackground, EditorSkin.Scene);

            public static GUIStyle ProfilerSelectedLabel => Styles.Get(Keys.ProfilerSelectedLabel, EditorSkin.Scene);
            public static GUIStyle ProfilerTimelineBar => Styles.Get(Keys.ProfilerTimelineBar, EditorSkin.Scene);

            public static GUIStyle ProfilerTimelineDigDownArrow =>
                Styles.Get(Keys.ProfilerTimelineDigDownArrow, EditorSkin.Scene);

            public static GUIStyle ProfilerTimelineFoldout =>
                Styles.Get(Keys.ProfilerTimelineFoldout, EditorSkin.Scene);

            public static GUIStyle ProfilerTimelineLeftPane =>
                Styles.Get(Keys.ProfilerTimelineLeftPane, EditorSkin.Scene);

            public static GUIStyle ProfilerTimelineRollUpArrow =>
                Styles.Get(Keys.ProfilerTimelineRollUpArrow, EditorSkin.Scene);

            public static GUIStyle ProgressBarBack => Styles.Get(Keys.ProgressBarBack, EditorSkin.Scene);
            public static GUIStyle ProgressBarBar => Styles.Get(Keys.ProgressBarBar, EditorSkin.Scene);
            public static GUIStyle ProgressBarText => Styles.Get(Keys.ProgressBarText, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserBottomBarBg =>
                Styles.Get(Keys.ProjectBrowserBottomBarBg, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserGridLabel =>
                Styles.Get(Keys.ProjectBrowserGridLabel, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserHeaderBgMiddle =>
                Styles.Get(Keys.ProjectBrowserHeaderBgMiddle, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserHeaderBgTop =>
                Styles.Get(Keys.ProjectBrowserHeaderBgTop, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserIconAreaBg =>
                Styles.Get(Keys.ProjectBrowserIconAreaBg, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserIconDropShadow, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserPreviewBg =>
                Styles.Get(Keys.ProjectBrowserPreviewBg, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetBg =>
                Styles.Get(Keys.ProjectBrowserSubAssetBg, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetBgCloseEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgCloseEnded, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetBgDivider =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgDivider, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetBgMiddle =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgMiddle, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetBgOpenEnded =>
                Styles.Get(Keys.ProjectBrowserSubAssetBgOpenEnded, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetExpandBtn =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtn, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnMedium =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnMedium, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserSubAssetExpandBtnSmall =>
                Styles.Get(Keys.ProjectBrowserSubAssetExpandBtnSmall, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserTextureIconDropShadow =>
                Styles.Get(Keys.ProjectBrowserTextureIconDropShadow, EditorSkin.Scene);

            public static GUIStyle ProjectBrowserTopBarBg => Styles.Get(Keys.ProjectBrowserTopBarBg, EditorSkin.Scene);
            public static GUIStyle QualitySettingsDefault => Styles.Get(Keys.QualitySettingsDefault, EditorSkin.Scene);
            public static GUIStyle quick_search_tab => Styles.Get(Keys.quick_search_tab, EditorSkin.Scene);
            public static GUIStyle Radio => Styles.Get(Keys.Radio, EditorSkin.Scene);
            public static GUIStyle RectangleToolHBar => Styles.Get(Keys.RectangleToolHBar, EditorSkin.Scene);
            public static GUIStyle RectangleToolHBarLeft => Styles.Get(Keys.RectangleToolHBarLeft, EditorSkin.Scene);
            public static GUIStyle RectangleToolHBarRight => Styles.Get(Keys.RectangleToolHBarRight, EditorSkin.Scene);
            public static GUIStyle RectangleToolHighlight => Styles.Get(Keys.RectangleToolHighlight, EditorSkin.Scene);

            public static GUIStyle RectangleToolRippleLeft =>
                Styles.Get(Keys.RectangleToolRippleLeft, EditorSkin.Scene);

            public static GUIStyle RectangleToolRippleRight =>
                Styles.Get(Keys.RectangleToolRippleRight, EditorSkin.Scene);

            public static GUIStyle RectangleToolScaleBottom =>
                Styles.Get(Keys.RectangleToolScaleBottom, EditorSkin.Scene);

            public static GUIStyle RectangleToolScaleLeft => Styles.Get(Keys.RectangleToolScaleLeft, EditorSkin.Scene);

            public static GUIStyle RectangleToolScaleRight =>
                Styles.Get(Keys.RectangleToolScaleRight, EditorSkin.Scene);

            public static GUIStyle RectangleToolScaleTop => Styles.Get(Keys.RectangleToolScaleTop, EditorSkin.Scene);
            public static GUIStyle RectangleToolSelection => Styles.Get(Keys.RectangleToolSelection, EditorSkin.Scene);
            public static GUIStyle RectangleToolVBar => Styles.Get(Keys.RectangleToolVBar, EditorSkin.Scene);

            public static GUIStyle RectangleToolVBarBottom =>
                Styles.Get(Keys.RectangleToolVBarBottom, EditorSkin.Scene);

            public static GUIStyle RectangleToolVBarTop => Styles.Get(Keys.RectangleToolVBarTop, EditorSkin.Scene);
            public static GUIStyle RegionBg => Styles.Get(Keys.RegionBg, EditorSkin.Scene);
            public static GUIStyle ReorderableList => Styles.Get(Keys.ReorderableList, EditorSkin.Scene);

            public static GUIStyle ReorderableListRightAligned =>
                Styles.Get(Keys.ReorderableListRightAligned, EditorSkin.Scene);

            public static GUIStyle RightAlignedLabel => Styles.Get(Keys.RightAlignedLabel, EditorSkin.Scene);
            public static GUIStyle RightLabel => Styles.Get(Keys.RightLabel, EditorSkin.Scene);
            public static GUIStyle RL_Background => Styles.Get(Keys.RL_Background, EditorSkin.Scene);
            public static GUIStyle RL_DragHandle => Styles.Get(Keys.RL_DragHandle, EditorSkin.Scene);
            public static GUIStyle RL_Element => Styles.Get(Keys.RL_Element, EditorSkin.Scene);
            public static GUIStyle RL_Empty_Header => Styles.Get(Keys.RL_Empty_Header, EditorSkin.Scene);
            public static GUIStyle RL_Footer => Styles.Get(Keys.RL_Footer, EditorSkin.Scene);
            public static GUIStyle RL_FooterButton => Styles.Get(Keys.RL_FooterButton, EditorSkin.Scene);
            public static GUIStyle RL_Header => Styles.Get(Keys.RL_Header, EditorSkin.Scene);
            public static GUIStyle SC_ViewAxisLabel => Styles.Get(Keys.SC_ViewAxisLabel, EditorSkin.Scene);
            public static GUIStyle SC_ViewLabel => Styles.Get(Keys.SC_ViewLabel, EditorSkin.Scene);
            public static GUIStyle SC_ViewLabelCentered => Styles.Get(Keys.SC_ViewLabelCentered, EditorSkin.Scene);

            public static GUIStyle SC_ViewLabelLeftAligned =>
                Styles.Get(Keys.SC_ViewLabelLeftAligned, EditorSkin.Scene);

            public static GUIStyle SceneTopBarBg => Styles.Get(Keys.SceneTopBarBg, EditorSkin.Scene);

            public static GUIStyle SceneViewOverlayTransparentBackground =>
                Styles.Get(Keys.SceneViewOverlayTransparentBackground, EditorSkin.Scene);

            public static GUIStyle SceneVisibility => Styles.Get(Keys.SceneVisibility, EditorSkin.Scene);
            public static GUIStyle ScriptText => Styles.Get(Keys.ScriptText, EditorSkin.Scene);
            public static GUIStyle ScrollViewAlt => Styles.Get(Keys.ScrollViewAlt, EditorSkin.Scene);
            public static GUIStyle SearchCancelButton => Styles.Get(Keys.SearchCancelButton, EditorSkin.Scene);

            public static GUIStyle SearchCancelButtonEmpty =>
                Styles.Get(Keys.SearchCancelButtonEmpty, EditorSkin.Scene);

            public static GUIStyle SearchModeFilter => Styles.Get(Keys.SearchModeFilter, EditorSkin.Scene);
            public static GUIStyle SearchTextField => Styles.Get(Keys.SearchTextField, EditorSkin.Scene);
            public static GUIStyle SelectionRect => Styles.Get(Keys.SelectionRect, EditorSkin.Scene);
            public static GUIStyle SettingsHeader => Styles.Get(Keys.SettingsHeader, EditorSkin.Scene);
            public static GUIStyle SettingsIconButton => Styles.Get(Keys.SettingsIconButton, EditorSkin.Scene);
            public static GUIStyle SettingsListItem => Styles.Get(Keys.SettingsListItem, EditorSkin.Scene);
            public static GUIStyle SettingsTreeItem => Styles.Get(Keys.SettingsTreeItem, EditorSkin.Scene);
            public static GUIStyle ShurikenCheckMark => Styles.Get(Keys.ShurikenCheckMark, EditorSkin.Scene);
            public static GUIStyle ShurikenCheckMarkMixed => Styles.Get(Keys.ShurikenCheckMarkMixed, EditorSkin.Scene);
            public static GUIStyle ShurikenDropdown => Styles.Get(Keys.ShurikenDropdown, EditorSkin.Scene);
            public static GUIStyle ShurikenEditableLabel => Styles.Get(Keys.ShurikenEditableLabel, EditorSkin.Scene);
            public static GUIStyle ShurikenEffectBg => Styles.Get(Keys.ShurikenEffectBg, EditorSkin.Scene);
            public static GUIStyle ShurikenEmitterTitle => Styles.Get(Keys.ShurikenEmitterTitle, EditorSkin.Scene);
            public static GUIStyle ShurikenLabel => Styles.Get(Keys.ShurikenLabel, EditorSkin.Scene);
            public static GUIStyle ShurikenMinus => Styles.Get(Keys.ShurikenMinus, EditorSkin.Scene);
            public static GUIStyle ShurikenModuleBg => Styles.Get(Keys.ShurikenModuleBg, EditorSkin.Scene);
            public static GUIStyle ShurikenModuleTitle => Styles.Get(Keys.ShurikenModuleTitle, EditorSkin.Scene);
            public static GUIStyle ShurikenObjectField => Styles.Get(Keys.ShurikenObjectField, EditorSkin.Scene);
            public static GUIStyle ShurikenPlus => Styles.Get(Keys.ShurikenPlus, EditorSkin.Scene);
            public static GUIStyle ShurikenPopup => Styles.Get(Keys.ShurikenPopup, EditorSkin.Scene);
            public static GUIStyle ShurikenToggle => Styles.Get(Keys.ShurikenToggle, EditorSkin.Scene);
            public static GUIStyle ShurikenToggleMixed => Styles.Get(Keys.ShurikenToggleMixed, EditorSkin.Scene);
            public static GUIStyle ShurikenValue => Styles.Get(Keys.ShurikenValue, EditorSkin.Scene);
            public static GUIStyle SliderMixed => Styles.Get(Keys.SliderMixed, EditorSkin.Scene);
            public static GUIStyle SoloToggle => Styles.Get(Keys.SoloToggle, EditorSkin.Scene);
            public static GUIStyle StaticDropdown => Styles.Get(Keys.StaticDropdown, EditorSkin.Scene);
            public static GUIStyle StatusBarIcon => Styles.Get(Keys.StatusBarIcon, EditorSkin.Scene);
            public static GUIStyle sv_iconselector_back => Styles.Get(Keys.sv_iconselector_back, EditorSkin.Scene);
            public static GUIStyle sv_iconselector_button => Styles.Get(Keys.sv_iconselector_button, EditorSkin.Scene);

            public static GUIStyle sv_iconselector_labelselection =>
                Styles.Get(Keys.sv_iconselector_labelselection, EditorSkin.Scene);

            public static GUIStyle sv_iconselector_selection =>
                Styles.Get(Keys.sv_iconselector_selection, EditorSkin.Scene);

            public static GUIStyle sv_iconselector_sep => Styles.Get(Keys.sv_iconselector_sep, EditorSkin.Scene);
            public static GUIStyle sv_label_0 => Styles.Get(Keys.sv_label_0, EditorSkin.Scene);
            public static GUIStyle sv_label_1 => Styles.Get(Keys.sv_label_1, EditorSkin.Scene);
            public static GUIStyle sv_label_2 => Styles.Get(Keys.sv_label_2, EditorSkin.Scene);
            public static GUIStyle sv_label_3 => Styles.Get(Keys.sv_label_3, EditorSkin.Scene);
            public static GUIStyle sv_label_4 => Styles.Get(Keys.sv_label_4, EditorSkin.Scene);
            public static GUIStyle sv_label_5 => Styles.Get(Keys.sv_label_5, EditorSkin.Scene);
            public static GUIStyle sv_label_6 => Styles.Get(Keys.sv_label_6, EditorSkin.Scene);
            public static GUIStyle sv_label_7 => Styles.Get(Keys.sv_label_7, EditorSkin.Scene);
            public static GUIStyle Tab_first => Styles.Get(Keys.Tab_first, EditorSkin.Scene);
            public static GUIStyle Tab_last => Styles.Get(Keys.Tab_last, EditorSkin.Scene);
            public static GUIStyle Tab_middle => Styles.Get(Keys.Tab_middle, EditorSkin.Scene);
            public static GUIStyle Tab_onlyOne => Styles.Get(Keys.Tab_onlyOne, EditorSkin.Scene);
            public static GUIStyle TabWindowBackground => Styles.Get(Keys.TabWindowBackground, EditorSkin.Scene);
            public static GUIStyle Tag_MenuItem => Styles.Get(Keys.Tag_MenuItem, EditorSkin.Scene);
            public static GUIStyle TE_BoxBackground => Styles.Get(Keys.TE_BoxBackground, EditorSkin.Scene);
            public static GUIStyle TE_DefaultTime => Styles.Get(Keys.TE_DefaultTime, EditorSkin.Scene);
            public static GUIStyle TE_DropField => Styles.Get(Keys.TE_DropField, EditorSkin.Scene);
            public static GUIStyle TE_ElementBackground => Styles.Get(Keys.TE_ElementBackground, EditorSkin.Scene);
            public static GUIStyle TE_NodeBackground => Styles.Get(Keys.TE_NodeBackground, EditorSkin.Scene);
            public static GUIStyle TE_NodeBox => Styles.Get(Keys.TE_NodeBox, EditorSkin.Scene);
            public static GUIStyle TE_NodeBoxSelected => Styles.Get(Keys.TE_NodeBoxSelected, EditorSkin.Scene);
            public static GUIStyle TE_NodeLabelBot => Styles.Get(Keys.TE_NodeLabelBot, EditorSkin.Scene);
            public static GUIStyle TE_NodeLabelTop => Styles.Get(Keys.TE_NodeLabelTop, EditorSkin.Scene);
            public static GUIStyle TE_PinLabel => Styles.Get(Keys.TE_PinLabel, EditorSkin.Scene);
            public static GUIStyle TE_Toolbar => Styles.Get(Keys.TE_Toolbar, EditorSkin.Scene);
            public static GUIStyle TE_toolbarbutton => Styles.Get(Keys.TE_toolbarbutton, EditorSkin.Scene);
            public static GUIStyle TE_ToolbarDropDown => Styles.Get(Keys.TE_ToolbarDropDown, EditorSkin.Scene);
            public static GUIStyle TextFieldDropDown => Styles.Get(Keys.TextFieldDropDown, EditorSkin.Scene);
            public static GUIStyle TextFieldDropDownText => Styles.Get(Keys.TextFieldDropDownText, EditorSkin.Scene);
            public static GUIStyle TimeAreaToolbar => Styles.Get(Keys.TimeAreaToolbar, EditorSkin.Scene);
            public static GUIStyle TimeRulerBackground => Styles.Get(Keys.TimeRulerBackground, EditorSkin.Scene);
            public static GUIStyle TimeScrubber => Styles.Get(Keys.TimeScrubber, EditorSkin.Scene);
            public static GUIStyle TimeScrubberButton => Styles.Get(Keys.TimeScrubberButton, EditorSkin.Scene);
            public static GUIStyle Titlebar_Foldout => Styles.Get(Keys.Titlebar_Foldout, EditorSkin.Scene);
            public static GUIStyle TL_InPoint => Styles.Get(Keys.TL_InPoint, EditorSkin.Scene);
            public static GUIStyle TL_OutPoint => Styles.Get(Keys.TL_OutPoint, EditorSkin.Scene);
            public static GUIStyle TL_Playhead => Styles.Get(Keys.TL_Playhead, EditorSkin.Scene);
            public static GUIStyle ToggleMixed => Styles.Get(Keys.ToggleMixed, EditorSkin.Scene);
            public static GUIStyle Toolbar => Styles.Get(Keys.Toolbar, EditorSkin.Scene);
            public static GUIStyle ToolbarBoldLabel => Styles.Get(Keys.ToolbarBoldLabel, EditorSkin.Scene);
            public static GUIStyle ToolbarBottom => Styles.Get(Keys.ToolbarBottom, EditorSkin.Scene);
            public static GUIStyle toolbarbutton => Styles.Get(Keys.toolbarbutton, EditorSkin.Scene);
            public static GUIStyle ToolbarButtonFlat => Styles.Get(Keys.ToolbarButtonFlat, EditorSkin.Scene);
            public static GUIStyle toolbarbuttonLeft => Styles.Get(Keys.toolbarbuttonLeft, EditorSkin.Scene);
            public static GUIStyle toolbarbuttonRight => Styles.Get(Keys.toolbarbuttonRight, EditorSkin.Scene);

            public static GUIStyle ToolbarCreateAddNewDropDown =>
                Styles.Get(Keys.ToolbarCreateAddNewDropDown, EditorSkin.Scene);

            public static GUIStyle ToolbarDropDown => Styles.Get(Keys.ToolbarDropDown, EditorSkin.Scene);
            public static GUIStyle ToolbarDropDownLeft => Styles.Get(Keys.ToolbarDropDownLeft, EditorSkin.Scene);
            public static GUIStyle ToolbarDropDownRight => Styles.Get(Keys.ToolbarDropDownRight, EditorSkin.Scene);
            public static GUIStyle ToolbarDropDownToggle => Styles.Get(Keys.ToolbarDropDownToggle, EditorSkin.Scene);

            public static GUIStyle ToolbarDropDownToggleRight =>
                Styles.Get(Keys.ToolbarDropDownToggleRight, EditorSkin.Scene);

            public static GUIStyle ToolbarLabel => Styles.Get(Keys.ToolbarLabel, EditorSkin.Scene);
            public static GUIStyle ToolbarPopup => Styles.Get(Keys.ToolbarPopup, EditorSkin.Scene);
            public static GUIStyle ToolbarPopupLeft => Styles.Get(Keys.ToolbarPopupLeft, EditorSkin.Scene);
            public static GUIStyle ToolbarPopupRight => Styles.Get(Keys.ToolbarPopupRight, EditorSkin.Scene);

            public static GUIStyle ToolbarSeachCancelButton =>
                Styles.Get(Keys.ToolbarSeachCancelButton, EditorSkin.Scene);

            public static GUIStyle ToolbarSeachCancelButtonEmpty =>
                Styles.Get(Keys.ToolbarSeachCancelButtonEmpty, EditorSkin.Scene);

            public static GUIStyle ToolbarSeachTextField => Styles.Get(Keys.ToolbarSeachTextField, EditorSkin.Scene);

            public static GUIStyle ToolbarSeachTextFieldPopup =>
                Styles.Get(Keys.ToolbarSeachTextFieldPopup, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchCancelButtonWithJump =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJump, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchCancelButtonWithJumpEmpty =>
                Styles.Get(Keys.ToolbarSearchCancelButtonWithJumpEmpty, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchField => Styles.Get(Keys.ToolbarSearchField, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchTextFieldJumpButton =>
                Styles.Get(Keys.ToolbarSearchTextFieldJumpButton, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchTextFieldWithJump =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJump, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopup =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopup, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchTextFieldWithJumpPopupSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpPopupSynced, EditorSkin.Scene);

            public static GUIStyle ToolbarSearchTextFieldWithJumpSynced =>
                Styles.Get(Keys.ToolbarSearchTextFieldWithJumpSynced, EditorSkin.Scene);

            public static GUIStyle ToolbarSlider => Styles.Get(Keys.ToolbarSlider, EditorSkin.Scene);
            public static GUIStyle ToolbarSliderTextField => Styles.Get(Keys.ToolbarSliderTextField, EditorSkin.Scene);
            public static GUIStyle ToolbarTextField => Styles.Get(Keys.ToolbarTextField, EditorSkin.Scene);
            public static GUIStyle Tooltip => Styles.Get(Keys.Tooltip, EditorSkin.Scene);
            public static GUIStyle TV_Insertion => Styles.Get(Keys.TV_Insertion, EditorSkin.Scene);
            public static GUIStyle TV_Line => Styles.Get(Keys.TV_Line, EditorSkin.Scene);
            public static GUIStyle TV_LineBold => Styles.Get(Keys.TV_LineBold, EditorSkin.Scene);
            public static GUIStyle TV_Ping => Styles.Get(Keys.TV_Ping, EditorSkin.Scene);
            public static GUIStyle TV_Selection => Styles.Get(Keys.TV_Selection, EditorSkin.Scene);
            public static GUIStyle U2D_createRect => Styles.Get(Keys.U2D_createRect, EditorSkin.Scene);
            public static GUIStyle U2D_dragDot => Styles.Get(Keys.U2D_dragDot, EditorSkin.Scene);
            public static GUIStyle U2D_dragDotActive => Styles.Get(Keys.U2D_dragDotActive, EditorSkin.Scene);
            public static GUIStyle U2D_dragDotDimmed => Styles.Get(Keys.U2D_dragDotDimmed, EditorSkin.Scene);
            public static GUIStyle U2D_pivotDot => Styles.Get(Keys.U2D_pivotDot, EditorSkin.Scene);
            public static GUIStyle U2D_pivotDotActive => Styles.Get(Keys.U2D_pivotDotActive, EditorSkin.Scene);

            public static GUIStyle VerticalMinMaxScrollbarThumb =>
                Styles.Get(Keys.VerticalMinMaxScrollbarThumb, EditorSkin.Scene);

            public static GUIStyle VerticalSliderThumbExtent =>
                Styles.Get(Keys.VerticalSliderThumbExtent, EditorSkin.Scene);

            public static GUIStyle VideoClipImporterLabel => Styles.Get(Keys.VideoClipImporterLabel, EditorSkin.Scene);
            public static GUIStyle WarningOverlay => Styles.Get(Keys.WarningOverlay, EditorSkin.Scene);
            public static GUIStyle WhiteBackground => Styles.Get(Keys.WhiteBackground, EditorSkin.Scene);
            public static GUIStyle WhiteBoldLabel => Styles.Get(Keys.WhiteBoldLabel, EditorSkin.Scene);
            public static GUIStyle WhiteLabel => Styles.Get(Keys.WhiteLabel, EditorSkin.Scene);
            public static GUIStyle WhiteLargeCenterLabel => Styles.Get(Keys.WhiteLargeCenterLabel, EditorSkin.Scene);
            public static GUIStyle WhiteLargeLabel => Styles.Get(Keys.WhiteLargeLabel, EditorSkin.Scene);
            public static GUIStyle WhiteMiniLabel => Styles.Get(Keys.WhiteMiniLabel, EditorSkin.Scene);
            public static GUIStyle WinBtn => Styles.Get(Keys.WinBtn, EditorSkin.Scene);
            public static GUIStyle WinBtnClose => Styles.Get(Keys.WinBtnClose, EditorSkin.Scene);
            public static GUIStyle WinBtnCloseMac => Styles.Get(Keys.WinBtnCloseMac, EditorSkin.Scene);
            public static GUIStyle WinBtnInactiveMac => Styles.Get(Keys.WinBtnInactiveMac, EditorSkin.Scene);
            public static GUIStyle WinBtnMax => Styles.Get(Keys.WinBtnMax, EditorSkin.Scene);
            public static GUIStyle WinBtnMaxMac => Styles.Get(Keys.WinBtnMaxMac, EditorSkin.Scene);
            public static GUIStyle WinBtnMinMac => Styles.Get(Keys.WinBtnMinMac, EditorSkin.Scene);
            public static GUIStyle WinBtnRestore => Styles.Get(Keys.WinBtnRestore, EditorSkin.Scene);
            public static GUIStyle WinBtnRestoreMac => Styles.Get(Keys.WinBtnRestoreMac, EditorSkin.Scene);
            public static GUIStyle WindowBottomResize => Styles.Get(Keys.WindowBottomResize, EditorSkin.Scene);
            public static GUIStyle Wizard_Box => Styles.Get(Keys.Wizard_Box, EditorSkin.Scene);
            public static GUIStyle Wizard_Error => Styles.Get(Keys.Wizard_Error, EditorSkin.Scene);
            public static GUIStyle WordWrapLabel => Styles.Get(Keys.WordWrapLabel, EditorSkin.Scene);
            public static GUIStyle wordwrapminibutton => Styles.Get(Keys.wordwrapminibutton, EditorSkin.Scene);
            public static GUIStyle WordWrappedLabel => Styles.Get(Keys.WordWrappedLabel, EditorSkin.Scene);
            public static GUIStyle WordWrappedMiniLabel => Styles.Get(Keys.WordWrappedMiniLabel, EditorSkin.Scene);
        }
    }
}
#endif