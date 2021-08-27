<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582293/10.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2723)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_BeginEndUpdate/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_BeginEndUpdate/Form1.vb))
* [Program.cs](./CS/XtraPivotGrid_BeginEndUpdate/Program.cs) (VB: [Program.vb](./VB/XtraPivotGrid_BeginEndUpdate/Program.vb))
<!-- default file list end -->
# How to lock pivot grid updates


<p>The following example demonstrates how to lock the pivot grid, thus preventing it from being redrawn while a sequence of operations that affect its appearance and/or functionality is being performed.</p><p>In this example, the pivot grid is transposed by moving Row Fields to the Column Area, and vice versa. Prior to this, the BeginUpdate method is called to lock the pivot grid. When the transposition is completed, the pivot grid is unlocked via the EndUpdate method. To ensure that the EndUpdate method is always called even if an exception occurs, calls to the BeginUpdate and EndUpdate methods are wrapped in a <strong>try...finally</strong> statement.</p>

<br/>


