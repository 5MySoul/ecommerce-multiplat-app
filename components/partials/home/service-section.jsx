import React from 'react';
import Reveal from "react-awesome-reveal";

import OwlCarousel from '~/components/features/owl-carousel';

import { serviceSlider } from '~/utils/data/carousel';
import { zoomInLeft } from '~/utils/data/keyframes';

function ServiceBox () {
    return (
        <section className="container">
            <div className="service-list">
                <OwlCarousel adClass="owl-theme owl-middle" options={ serviceSlider }>
                    <Reveal keyframes={ zoomInLeft } delay={ 200 } duration={ 1200 } triggerOnce>
                        <div className="icon-box text-center">
                            <i className="icon-box-icon d-icon-truck" style={ { fontSize: "4.4rem" } }></i>
                            <div className="icon-box-content">
                                <h4 className="icon-box-title">Free Shipping &amp; Return</h4>
                                <p>Free shipping on orders over $99</p>
                            </div>
                        </div>
                    </Reveal>

                    <Reveal keyframes={ zoomInLeft } delay={ 300 } duration={ 1200 } triggerOnce>
                        <div className="icon-box text-center">
                            <i className="icon-box-icon d-icon-headphone" style={ { fontSize: "3.4rem" } }></i>
                            <div className="icon-box-content">
                                <h4 className="icon-box-title">Customer Support 24/7</h4>
                                <p>Instant access to perfect support</p>
                            </div>
                        </div>
                    </Reveal>

                    <Reveal keyframes={ zoomInLeft } delay={ 400 } duration={ 1200 } triggerOnce>
                        <div className="icon-box text-center">
                            <i className="icon-box-icon d-icon-secure" style={ { fontSize: "3.7rem" } }></i>
                            <div className="icon-box-content">
                                <h4 className="icon-box-title">100% Secure Payment</h4>
                                <p>We ensure secure payment!</p>
                            </div>
                        </div>
                    </Reveal>

                    <Reveal keyframes={ zoomInLeft } delay={ 500 } duration={ 1200 } triggerOnce>
                        <div className="icon-box text-center">
                            <i className="icon-box-icon d-icon-money" style={ { fontSize: "3.2rem" } }></i>
                            <div className="icon-box-content">
                                <h4 className="icon-box-title">Money Back guarantee</h4>
                                <p>Any back within 30days</p>
                            </div>
                        </div>
                    </Reveal>
                </OwlCarousel>
            </div>
        </section >
    )
}

export default React.memo( ServiceBox );