import React from 'react';
import Reveal from 'react-awesome-reveal';
import { LazyLoadImage } from 'react-lazy-load-image-component';

import ALink from '~/components/features/custom-link';
import OwlCarousel from '~/components/features/owl-carousel';

import { fadeIn, fadeInRightShorter, fadeInLeftShorter } from '~/utils/data/keyframes';
import { bannerSlider } from '~/utils/data/carousel';

function BannerSection () {
    return (
        <section className="banner-group container mt-10 pb-4 pt-2 mb-10">
            <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                <OwlCarousel adClass="owl-theme" options={ bannerSlider }>
                    <Reveal keyframes={ fadeInRightShorter } delay={ 200 } duration={ 1200 } triggerOnce>
                        <div className="banner1 banner banner-fixed overlay-zoom" style={ { backgroundColor: "#3cbea4" } }>
                            <figure>
                                <LazyLoadImage
                                    src="./images/home/banner/1.jpg"
                                    alt="banner"
                                    effect="opacity; transform;"
                                    width="auto"
                                    height={ 219 }
                                />
                            </figure>
                            <div className="banner-content y-50">
                                <h3 className="banner-title text-white ls-normal lh-1">Customized Products</h3>
                                <p className="mb-7 text-white">Partner with one of 8,000 experienced manufacturers with design & production capabilities</p>
                                <ALink href="/shop" className="btn btn-link btn-white btn-underline font-weight-bold">Oem Factories<i className="fas fa-angle-right"></i></ALink>
                                <ALink href="/shop" className="btn btn-link btn-white btn-underline font-weight-bold">Top suppliers<i className="fas fa-angle-right"></i></ALink>
                            </div>
                        </div>
                    </Reveal>

                    <Reveal keyframes={ fadeInLeftShorter } delay={ 200 } duration={ 1200 } triggerOnce>
                        <div className="banner2 banner banner-fixed overlay-zoom" style={ { backgroundColor: "#444443" } }>
                            <figure>
                                <LazyLoadImage
                                    src="./images/home/banner/2.jpg"
                                    alt="banner"
                                    effect="opacity; transform;"
                                    width="auto"
                                    height={ 219 }
                                />
                            </figure>
                            <div className="banner-content y-50">
                                <h3 className="banner-title text-white ls-normal lh-1">Ready-To-Ship Products</h3>
                                <p className="mb-7 text-white">Source from 15 milion products that are ready to ship, and leave the facility within 15 days</p>
                                <ALink href="/shop" className="btn btn-link btn-white btn-underline font-weight-bold">New Arrivals<i className="fas fa-angle-right"></i></ALink>
                                <ALink href="/shop" className="btn btn-link btn-white btn-underline font-weight-bold">Best Sellers<i className="fas fa-angle-right"></i></ALink>
                            </div>
                        </div>
                    </Reveal>
                </OwlCarousel>
            </Reveal>
        </section>
    )
}

export default React.memo( BannerSection );