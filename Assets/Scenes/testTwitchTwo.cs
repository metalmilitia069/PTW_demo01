// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.
//using UnityEngine;
//using System.Collections;




//public class testTwitchTwo : MonoBehaviour
//{
//	// make a request to twitch to get the access token to view stream
//	const fetch = require('node-fetch');
//	const { URLSearchParams
//}= require('url');
//const twitchClientId = "kimne78kx3ncx6brgo4mv6wki5h1ko";
//const getAccessToken = async function (channel) {
//	const data = JSON.stringify({
//	operationName: "PlaybackAccessToken",
//		extensions:
//		{
//		persistedQuery:
//			{
//			version: 1,
//				sha256Hash: "0828119ded1c13477966434e15800ff57ddacf13ba1911c129dc2200705b0712"
//			}
//		},
//		variables:
//		{
//		isLive: true,
//			login: channel,
//			isVod: false,
//			vodID: "",
//			playerType: "embed"
//		}
//	});
//	let url = `https://gql.twitch.tv/gql`
//	let response = await fetch(url, {
//		"headers": {
//			"Client-Id": "kimne78kx3ncx6brgo4mv6wki5h1ko"

//		},
//        "body": data,
//        "method": "POST"

//	})
//    let body = await response.json();
//	return Promise.resolve(body.data.streamPlaybackAccessToken)
//}
//const getStreamURL = async function (channel) {
//	let accessToken = await getAccessToken(channel)

//	let url = `https://usher.ttvnw.net/api/channel/hls/${channel}.m3u8?client_id=${twitchClientId}&token=${accessToken.value}&sig=${accessToken.signature}&allow_source=true&allow_audio_only=true`
//	return Promise.resolve(url)
//}
//// get the stream from channel name
//let channel = "loltyler1"
//getStreamURL(channel).then(url => { console.log(url) });
//// play the stream in a HLS player
//}







