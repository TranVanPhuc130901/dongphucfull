namespace Extensions
{
    /// <summary>
    /// Thực hiện việc lấy các link phân trang (link phân trang chứa các nút như: trang đầu, trang cuối, tiếp theo, về trước, các trang số 1,2,3,...)
    /// </summary>
    public class PagingExtensions
    {
        public static string SpilitPagesNoRewrite(int totalRows, int pageSize, int p, string link, string currentPageCss, string otherPageCss, string firstPageCss, string lastPageCss, string previewPageCss, string nextPageCss)
        {
            var numpages = 0;
            numpages = totalRows / pageSize;
            if (totalRows % pageSize > 0) numpages += 1;
            if (p < 0) p = 0;
            string prvpage = "", nxtpage = "";
            if (p > 1) prvpage = "<li class='page-item'><a class='page-link " + previewPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + (p - 1) + "'>|<</a></li>";
            if (numpages > 2 && p < numpages) nxtpage = "<li class='page-item'><a class='page-link " + nextPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + (p + 1) + "'>>|</a></li>";

            var firstPage = "<li class='page-item'><a class='page-link " + firstPageCss + "' href='" + link + "&ni=" + totalRows + "&p=1'>First</a></li>";
            var endPage = "<li class='page-item'><a class='page-link " + lastPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + numpages + "'>Last</a></li>";
            if (numpages <= 1) return "";
            var strPage = "";
            if (numpages < 10)
            {
                for (var i = 0; i < numpages; i++)
                {
                    if (p == (i + 1))
                    {
                        strPage += "<li class='page-item'><a class='page-link " + currentPageCss + "' href='javascript:void(0);'>" + (i + 1) + "</a></li>";
                    }
                    else
                    {
                        strPage += "<li class='page-item'><a class='page-link " + otherPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + (i + 1) + "'>" + (i + 1) + "</a></li>";
                    }
                }
            }
            else
            {
                if (p < 10)
                {
                    for (var i = 0; i < 10; i++)
                    {
                        if (p == (i + 1))
                        {
                            strPage += "<li class='page-item'><a class='page-link " + currentPageCss + "' href='javascript:void(0);'>" + (i + 1) + "</a></li>";
                        }
                        else
                        {
                            strPage += "<li class='page-item'><a class='page-link " + otherPageCss + "'  href='" + link + "&ni=" + totalRows + "&p=" + (i + 1) + "'>" + (i + 1) + "</a></li>";
                        }
                    }
                }
                else if (p > numpages - 5)
                {
                    for (var i = numpages - 5; i < numpages; i++)
                    {
                        if (p == (i + 1))
                        {
                            strPage += "<li class='page-item'><a class='page-link " + currentPageCss + "' href='javascript:void(0);'>" + (i + 1) + "</a></li>";
                        }
                        else
                        {
                            strPage += "<li class='page-item'><a class='page-link " + otherPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + (i + 1) + "'>" + (i + 1) + "</a></li>";
                        }
                    }
                }
                else
                {
                    for (var i = p - 5; i < p + 5; i++)
                    {
                        if (p == (i + 1))
                        {
                            strPage += "<li class='page-item'><a class='page-link " + currentPageCss + "' href='javascript:void(0);'>" + (i + 1) + "</a></li>";
                        }
                        else
                        {
                            strPage += "<li class='page-item'><a class='page-link " + otherPageCss + "' href='" + link + "&ni=" + totalRows + "&p=" + (i + 1) + "'>" + (i + 1) + "</a></li>";
                        }
                    }
                }
            }
            strPage = "<ul class='paging'> " + firstPage + prvpage + strPage + nxtpage + endPage + " </ul>";
            return strPage;
        }
    }
}
