package crc6468da811518fe3e30;


public class WebViewCallBackTwo
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageFinished:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_onLoadResource:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnLoadResource_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_onReceivedError:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceError;)V:GetOnReceivedError_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Landroid_webkit_WebResourceError_Handler\n" +
			"n_onReceivedHttpError:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceResponse;)V:GetOnReceivedHttpError_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Landroid_webkit_WebResourceResponse_Handler\n" +
			"";
		mono.android.Runtime.register ("ReceiptRental.Droid.DependencyService.WebViewCallBackTwo, ReceiptRental.Android", WebViewCallBackTwo.class, __md_methods);
	}


	public WebViewCallBackTwo ()
	{
		super ();
		if (getClass () == WebViewCallBackTwo.class)
			mono.android.TypeManager.Activate ("ReceiptRental.Droid.DependencyService.WebViewCallBackTwo, ReceiptRental.Android", "", this, new java.lang.Object[] {  });
	}


	public void onPageFinished (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onPageFinished (p0, p1);
	}

	private native void n_onPageFinished (android.webkit.WebView p0, java.lang.String p1);


	public void onLoadResource (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onLoadResource (p0, p1);
	}

	private native void n_onLoadResource (android.webkit.WebView p0, java.lang.String p1);


	public void onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2)
	{
		n_onReceivedError (p0, p1, p2);
	}

	private native void n_onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2);


	public void onReceivedHttpError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceResponse p2)
	{
		n_onReceivedHttpError (p0, p1, p2);
	}

	private native void n_onReceivedHttpError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceResponse p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
