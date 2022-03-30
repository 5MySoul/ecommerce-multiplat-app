import ALink from "~/components/features/custom-link";
import { useEffect } from "react";
import { useRouter } from "next/router";

// import CartMenu from "~/components/common/partials/cart-menu";
import MainMenu from "~/components/common/partials/main-menu";
// import SearchBox from "~/components/common/partials/search-box";
import LoginModal from "~/components/features/modals/login-modal";

export default function Header() {
  const router = useRouter();

  useEffect(() => {
    if (router.pathname !== "/") {
      document.querySelector(".category-dropdown.dropdown").classList.contains("fixed") &&
        document.querySelector(".category-dropdown.dropdown").classList.remove("fixed");
    } else {
      document.querySelector(".category-dropdown.dropdown").classList.add("fixed");
    }
  }, [router.pathname]);

  const showMobileMenu = () => {
    document.querySelector("body").classList.add("mmenu-active");
  };

  return (
    <header className="header">
      <div className="header-top">
        <div className="container">
          <div className="header-left">
            <p className="welcome-msg pb-2">Welcome to Top Home Shopping~!</p>
          </div>

          <div className="header-right">
            <div className="dropdown dropdown-expanded">
              <ALink href="#">LINKS</ALink>
              <ul className="dropdown-box">
                <li>
                  <ALink href="/pages/about-us">About</ALink>
                </li>
                <li>
                  <ALink href="/blog/classic">Blog</ALink>
                </li>
                <li>
                  <ALink href="/pages/faqs">FAQ</ALink>
                </li>
                <li>
                  <ALink href="#">Newsletter</ALink>
                </li>
                <li>
                  <ALink href="/pages/contact-us">Contact</ALink>
                </li>
                <li>
                  <LoginModal />
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>

      <div className="header-middle sticky-header fix-top sticky-content">
        <div className="container">
          <div className="header-left">
            <ALink href="#" className="mobile-menu-toggle" onClick={showMobileMenu}>
              <i className="d-icon-bars2"></i>
            </ALink>

            <ALink href="/" className="logo">
              <img src="./images/home/logo.png" alt="logo" width="154" height="43" />
            </ALink>

            {/* <SearchBox /> */}
          </div>

          <div className="header-right">
            <ALink href="tel:#" className="icon-box icon-box-side">
              <div className="icon-box-icon">
                <i className="d-icon-phone"></i>
              </div>
              <div className="icon-box-content d-lg-show">
                <h4 className="icon-box-title">Call Us Now:</h4>
                <p>0(800) 123-456</p>
              </div>
            </ALink>

            <span className="divider"></span>

            <ALink href="/pages/wishlist" className="wishlist">
              <i className="d-icon-heart"></i>
            </ALink>

            <span className="divider"></span>

            {/* <CartMenu /> */}
          </div>
        </div>
      </div>

      <div className="header-bottom has-dropdown pb-0">
        <div className="container d-flex align-items-center">
          <div className="dropdown category-dropdown has-border fixed">
            <ALink href="#" className="text-white font-weight-semi-bold category-toggle">
              <i className="d-icon-bars2"></i>
              <span>Shop By Categories</span>
            </ALink>

            <div className="dropdown-box">
              <ul className="menu vertical-menu category-menu">
                <li>
                  <ALink href="#" className="menu-title">
                    Browse Our Categories
                  </ALink>
                </li>

                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "electronics" } }}>
                    <i className="d-icon-camera1"></i>Electronics
                  </ALink>
                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "air-conditioners" } }}>Air Conditioners</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "machines" } }}>Machines</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "musical-instrument" } }}>Musical Instrument</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "office-electronics" } }}>Office Electronics</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "televisions" } }}>Televisions</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "video-recoders" } }}>Video Recorders</ALink>
                    </li>
                  </ul>
                </li>
                <li>
                  <ALink href={{ pathname: "/shop", query: { category: "backpacks-and-fashion-bags" } }}>
                    <i className="d-icon-officebag"></i>Backpacks &amp; Fashion Bags
                  </ALink>
                </li>
                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "fashion-and-clothings" } }}>
                    <i className="d-icon-t-shirt1" style={{ fontSize: "22px", marginRight: ".7rem" }}></i>Travel &amp; Clothings
                  </ALink>
                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "bikinies" } }}>Bikinies</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "casual-dresses" } }}>Casual Dresses</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "hair-accessories-and-hats" } }}>
                        Hair Accessories &amp; Hats
                      </ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "jackets" } }}>Jackets</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "jumpsuits-and-t-shirts" } }}>Jumpsuits &amp; T-Shirts</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "fashion-new-arrivals" } }}>New Arrivals</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "summer-dresses" } }}>Summer Dresses</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "sunglasses" } }}>Sunglasses</ALink>
                    </li>
                  </ul>
                </li>
                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "computers" } }}>
                    <i className="d-icon-desktop"></i>Computers
                  </ALink>
                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "desktop-pcs" } }}>Desktop PCs</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "laptops" } }}>Laptops</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "computer-new-arrivals" } }}>New Arrivals</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "pc-components" } }}>PC Components</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "pc-gaming" } }}>PC Gaming</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "storage-and-memory" } }}>Storage & Memory</ALink>
                    </li>
                  </ul>
                </li>
                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "beauty-and-fragrance" } }}>
                    <i className="d-icon-heart"></i>Beauty &amp; Fragrance
                  </ALink>

                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "hair-care" } }}>Hair Care</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "makeup" } }}>Makeup</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "beauty-new-arrivals" } }}>New Arrivals</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "perfumes" } }}>Perfumes</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "skin-care" } }}>Skin Care</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "tools-and-equipments" } }}>Tools &amp; Equipments</ALink>
                    </li>
                  </ul>
                </li>
                <li>
                  <ALink href={{ pathname: "/shop", query: { category: "headgears" } }}>
                    <i className="d-icon-hat" style={{ fontSize: "22px", marginRight: ".8rem" }}></i>Headgears
                  </ALink>
                </li>
                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "home-and-kitchen" } }}>
                    <i className="d-icon-cook"></i>Home &amp; Kitchen
                  </ALink>
                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "cookwaves" } }}>Cookwaves</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "decor" } }}>Decor</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "furnitures" } }}>Furniture</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "garden-tools" } }}>Garden Tools</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "home-new-arrivals" } }}>New Arrivals</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "utensil-and-gadgets" } }}>Utensil &amp; Gadgets</ALink>
                    </li>
                  </ul>
                </li>
                <li className="submenu">
                  <ALink href={{ pathname: "/shop", query: { category: "jewelry-and-watches" } }}>
                    <i className="d-icon-watch"></i>Jewelry &amp; Watches
                  </ALink>
                  <ul>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "accessories" } }}>Accessories</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "bracelets" } }}>Bracelets</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "necklace" } }}>Necklace</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "pendant" } }}>Pendant</ALink>
                    </li>
                    <li>
                      <ALink href={{ pathname: "/shop", query: { category: "watch" } }}>Watch</ALink>
                    </li>
                  </ul>
                </li>
                <li>
                  <ALink href={{ pathname: "/shop", query: { category: "shoes" } }}>
                    <i className="d-icon-shoes" style={{ fontSize: "2.2rem", marginRight: ".8rem" }}></i>Shoes
                  </ALink>
                </li>
              </ul>
            </div>
          </div>

          <MainMenu />

          <div className="d-flex align-items-center ml-auto">
            <div className="dropdown currency-dropdown mr-4 ls-normal">
              <ALink href="#currency">USD</ALink>
              <ul className="dropdown-box">
                <li>
                  <ALink href="#">USD</ALink>
                </li>
                <li>
                  <ALink href="#">EUR</ALink>
                </li>
              </ul>
            </div>
            <div className="dropdown language-dropdown ls-normal">
              <ALink href="#language">ENG</ALink>
              <ul className="dropdown-box">
                <li>
                  <ALink href="#">ENG</ALink>
                </li>
                <li>
                  <ALink href="#">FRH</ALink>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </header>
  );
}
