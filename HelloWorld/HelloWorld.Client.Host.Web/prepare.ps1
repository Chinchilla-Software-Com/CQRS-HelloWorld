Param( 
	[string] $sourceFolder, 
	[string] $targetFolder, 
	[string] $filter ## *.css,*.js,*.png,*.jpg,*.gif,*.htm,*.html 
) 
$source = "$sourceFolder\*" 
Get-ChildItem -Path "$sourceFolder\*" -Recurse -Filter $filter |  foreach { 
	$DestFile =  $_.Fullname.Substring($sourceFolder.Length - 1) 
	$DestFile =  "$targetFolder\$DestFile" 
	$null = New-Item -Path  $DestFile -Type File -Force 
	Copy-Item -Path  $_.FullName -Destination $DestFile -Force 
} 
