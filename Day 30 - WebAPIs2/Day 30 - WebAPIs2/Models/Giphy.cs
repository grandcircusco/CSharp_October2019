using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_30___WebAPIs2.Models
{

    public class Giphy
    {
        public Datum[] data { get; set; }
        public Pagination pagination { get; set; }
        public Meta meta { get; set; }
    }

    public class Pagination
    {
        public int total_count { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
    }

    public class Meta
    {
        public int status { get; set; }
        public string msg { get; set; }
        public string response_id { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string slug { get; set; }
        public string bitly_gif_url { get; set; }
        public string bitly_url { get; set; }
        public string embed_url { get; set; }
        public string username { get; set; }
        public string source { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string content_url { get; set; }
        public string source_tld { get; set; }
        public string source_post_url { get; set; }
        public int is_sticker { get; set; }
        public string import_datetime { get; set; }
        public string trending_datetime { get; set; }
        public Images images { get; set; }
        public User user { get; set; }
        public Analytics analytics { get; set; }
    }

    public class Images
    {
        public Downsized_Large downsized_large { get; set; }
        public Fixed_Height_Small_Still fixed_height_small_still { get; set; }
        public Original original { get; set; }
        public Fixed_Height_Downsampled fixed_height_downsampled { get; set; }
        public Downsized_Still downsized_still { get; set; }
        public Fixed_Height_Still fixed_height_still { get; set; }
        public Downsized_Medium downsized_medium { get; set; }
        public Downsized downsized { get; set; }
        public Preview_Webp preview_webp { get; set; }
        public Original_Mp4 original_mp4 { get; set; }
        public Fixed_Height_Small fixed_height_small { get; set; }
        public Fixed_Height fixed_height { get; set; }
        public Downsized_Small downsized_small { get; set; }
        public Preview preview { get; set; }
        public Fixed_Width_Downsampled fixed_width_downsampled { get; set; }
        public Fixed_Width_Small_Still fixed_width_small_still { get; set; }
        public Fixed_Width_Small fixed_width_small { get; set; }
        public Original_Still original_still { get; set; }
        public Fixed_Width_Still fixed_width_still { get; set; }
        public Looping looping { get; set; }
        public Fixed_Width fixed_width { get; set; }
        public Preview_Gif preview_gif { get; set; }
        public _480W_Still _480w_still { get; set; }
    }

    public class Downsized_Large
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Height_Small_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Original
    {
        public string frames { get; set; }
        public string hash { get; set; }
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Height_Downsampled
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Downsized_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Height_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Downsized_Medium
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Downsized
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Preview_Webp
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Original_Mp4
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Height_Small
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Height
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Downsized_Small
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string width { get; set; }
    }

    public class Preview
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Width_Downsampled
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Width_Small_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Width_Small
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Original_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Fixed_Width_Still
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class Looping
    {
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class Fixed_Width
    {
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string width { get; set; }
    }

    public class Preview_Gif
    {
        public string height { get; set; }
        public string size { get; set; }
        public string url { get; set; }
        public string width { get; set; }
    }

    public class _480W_Still
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }

    public class User
    {
        public string avatar_url { get; set; }
        public string banner_image { get; set; }
        public string banner_url { get; set; }
        public string profile_url { get; set; }
        public string username { get; set; }
        public string display_name { get; set; }
        public bool is_verified { get; set; }
    }

    public class Analytics
    {
        public Onload onload { get; set; }
        public Onclick onclick { get; set; }
        public Onsent onsent { get; set; }
    }

    public class Onload
    {
        public string url { get; set; }
    }

    public class Onclick
    {
        public string url { get; set; }
    }

    public class Onsent
    {
        public string url { get; set; }
    }
}
