Param( 
	[string] $url, 
	[string] $path 
) 
[System.Net.ServicePointManager]::ServerCertificateValidationCallback = {$true} 
$WebClient = New-Object net.webclient 
$path="$path\index.htm" 
## $WebClient.DownloadFile($url, $path) 
$content=$WebClient.DownloadString($url) 
$fileContent = $content.Replace("/HelloWorld/Client", "") 
$fileContent | Out-File $path 
