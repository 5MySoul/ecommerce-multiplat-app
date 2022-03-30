import React from 'react';
import Reveal from "react-awesome-reveal";
import { LazyLoadImage } from 'react-lazy-load-image-component';

import ALink from '~/components/features/custom-link';

import { fadeIn, fadeInRightShorter, fadeInDownShorter, fadeInLeftShorter, fadeInUpShorter } from '~/utils/data/keyframes';

function CategorySection() {
    return (
        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
            <section className="categories container mt-10">
                <h2 className="title title-line title-underline border-1 mb-4">Top Categories of the Month</h2>

                <div className="row">
                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/1.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'electronics' } } }>Electronics</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'air-conditioners' } } }>Air Conditioners</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'machines' } } }>Machines</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'musical-instrument' } } }>Musical Instrument</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'office-electronics' } } }>Office Electronics</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'televisions' } } }>Televisions</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>

                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/2.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'fashion-and-clothings' } } }>Fashion &amp; Clothings</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'bikinies' } } }>Bikinies</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'casual-dresses' } } }>Casual Dresses</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'hair-accessories-and-hats' } } }>Hair Accessories &amp; Hats</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'jackets' } } }>Jackets</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'jumpsuits-and-t-shirts' } } }>Jumpsuits &amp; T-shirts</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>

                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/3.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'computers' } } }>Computers</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'desktop-pcs' } } }>Desktop PCs</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'laptops' } } }>Laptops</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'computer-new-arrivals' } } }>New Arrivals</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'pc-components' } } }>PC Components</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'pc-gaming' } } }>PC Gaming</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>

                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/4.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'home-and-kitchen' } } }>Home &amp; Kitchen</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'cookwaves' } } }>Cookwaves</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'decor' } } }>Decor</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'furnitures' } } }>Furniture</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'garden-tools' } } }>Garden Tools</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'home-new-arrivals' } } }>New Arrivals</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>

                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/5.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'beauty-and-fragrance' } } }>Beauty &amp; Fragrance</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'hair-care' } } }>Hair Care</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'makeup' } } }>Makeup</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'beauty-new-arrivals' } } }>New Arrivals</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'perfumes' } } }>Perfumes</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'skin-care' } } }>Skin Care</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>

                    <div className="col-xl-4 col-md-6 mb-4">
                        <Reveal keyframes={ fadeIn } delay={ 200 } duration={ 1200 } triggerOnce>
                            <div className="category category-group-image">
                                <ALink href="#">
                                    <figure className="category-media">
                                        <LazyLoadImage
                                            src="./images/home/categories/6.png"
                                            alt="category banner"
                                            effect="opacity;"
                                            width="auto"
                                            height={ 169 }
                                        />
                                    </figure>
                                </ALink>
                                <div className="category-content">
                                    <h4 className="category-name"><ALink href={ { pathname: '/shop', query: { category: 'jewelry-and-watches' } } }>Jewelry &amp; Watches</ALink></h4>
                                    <ul className="category-list">
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'accessories' } } }>Accessories</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'bracelets' } } }>Bracelets</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'necklace' } } }>Necklace</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'pendant' } } }>Pendant</ALink></li>
                                        <li><ALink href={ { pathname: '/shop', query: { category: 'watch' } } }>Watch</ALink></li>
                                    </ul>
                                </div>
                            </div>
                        </Reveal>
                    </div>
                </div>
            </section>
        </Reveal>
    )
}

export default React.memo( CategorySection );