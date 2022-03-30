import React from "react";
import Helmet from "react-helmet";

// Import Apollo Server and Query

import { GET_HOME_DATA } from "../server/queries";

// import Home Components
// import NewsletterModal from "~/components/features/modals/newsletter-modal";
import IntroSection from "~/components/partials/home/intro-section";
import CategorySection from "~/components/partials/home/category-section";
import BannerSection from "~/components/partials/home/banner-section";
// import ProductCollection from "~/components/partials/home/product-collection";
import ServiceBox from "~/components/partials/home/service-section";
// import BlogSection from "~/components/partials/home/blog-section";

function HomePage() {
  //   const { data, loading, error } = useQuery(GET_HOME_DATA);
  //   const posts = data && data.posts.data;

  return (
    <div className="main home mt-lg-4 homepage">
      <Helmet>
        <title>TOP HOME SHOPPING - Home</title>
      </Helmet>

      <h1 className="d-none">TOP HOME SHOPPING - Home</h1>

      <div className="page-content">
        <IntroSection />

        <CategorySection />

        <BannerSection />

        {/* <div className="grey-section pt-10 pb-8">
          <div className="container pt-4 pb-4">
            <ProductCollection />

            <ProductCollection
              id={1}
              wrapperAdClass="mt-10 pt-4"
              adClass="pl-lg-2 pr-lg-2 text-lg-center pt-4"
              url="./images/home/banner/4.jpg"
              subTitle="Recommended for you"
              title="Cosmetics Trends"
              titleAdClass=""
            />

            <ProductCollection id={2} wrapperAdClass="mt-10 pt-4" url="./images/home/banner/5.jpg" title="Top Electronics" />

            <ProductCollection
              id={3}
              wrapperAdClass="mt-10 pt-4"
              adClass="text-lg-center"
              url="./images/home/banner/6.jpg"
              subTitle="Recommeded for you"
              title="Kitchen Tools"
            />
          </div>
        </div> */}

        <ServiceBox />

        {/* <BlogSection posts={ posts } /> */}
      </div>

      {/* <NewsletterModal /> */}
    </div>
  );
}

export default HomePage;
