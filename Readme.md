# How to: Customize Bars and Items at Runtime and Serialize the Layout into a File


<p>Bars and items in BarManager can be <a href="https://documentation.devexpress.com/#WPF/CustomDocument6521">customized</a> at runtime. </p>
<p>The Customization Mode as well as the Customization Window can be invoked using one of the following methods:</p>
<p>-By double-clicking an empty region within BarContainerControl.<br>-By right-clicking a bar or an empty region and selecting <strong>Customize</strong>.<br>-By clicking a bar's Down Arrow button and selecting <strong>Customize</strong> in the menu that opens.<br><br>To divide items into groups in the Customization Window, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfBarsBarItem_CategoryNametopic.aspx">BarItem.CategoryName</a> property. It's also possible to assign an item description using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarItem_Descriptiontopic">BarItem.Description</a> property.<br><br>All runtime bar customizations can be saved into a stream or file using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarManager_SaveLayoutToStreamtopic">SaveLayoutToStream</a> and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarManager_SaveLayoutToXmltopic">SaveLayoutToXml</a> methods.</p>

<br/>


